using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    
    //se perdi puoi scegliere di ricominciare, oppure di andare al menù
    public string loadMenuRestart;

    public string loadMenu;

    public string endMenu;

    //timer per la vita
    public static float t=5f;//tempo che serve a misurare dopo quanto il conta chilometri si deve aggiornare
    public static float t1=50f;//tempo timer dopo il quale il personaggio perde vita perché non si nutre
    public static float t2 = 2f;

    //Punteggio chilometri
    [SerializeField]
    //public Text PuntiText;

    public Text metri;
    public Text chilometri;
    public Text metriEnd;
    public Text chilometriEnd;


    //public Text highScore;
    public int scoreM = 0;//quanti metri
    public int scoreK = 0;//quanti chilometri

    //vita Personaggio
    float maxhealth=100;



    public float health = 100;

    Image healthBar;
    float barWidth,barHeight,healtCurrent;
    
    // Start is called before the first frame update
    void Start()
    {
        health =maxhealth;
        healthBar = GameObject.FindGameObjectWithTag("barraVita").GetComponent<Image>();
       

        barWidth =healthBar.rectTransform.sizeDelta.x;
        barHeight= healthBar.rectTransform.sizeDelta.y;
        //health = Getint("health");
    }

        public void SetInt(string KeyName, float Value)
        {
            PlayerPrefs.SetFloat(KeyName, Value);
        }

        public float Getint(string KeyName)
        {
            return PlayerPrefs.GetFloat(KeyName);
        }
 

    // Update is called once per frame
    void Update()
    {
        metriEnd = metri;
        chilometriEnd = chilometri;
        t -= Time.deltaTime;//scaduto il tempo, i metri aumentano
        bool v=false;
        while(t<0){
            scoreM++;
            if(scoreM<=9)
            {
                metri.text =scoreM.ToString();
            }
            else
            {
                scoreM=0;
                metri.text =scoreM.ToString();
                scoreK++;
                chilometri.text = scoreK.ToString();

            }
            /*if (scoreM == 8)
            {
                Application.LoadLevel("GordoDue");
            }*/
            t=5;
        }

        t1 -=Time.deltaTime;//se questo tempo scade, la vita si decrementa (NON STAI MANGIANDO)
        while(t1<0){
            DelVita(25);
            t1=50;
        }

        if(health==0)
        {
            //ScriptName sn = gameObject.GetComponent<PauseMenu>();
            // sn.PauseUnpause();
            healthBar.rectTransform.sizeDelta = new Vector2(0, barHeight);
            PauseGame();
            gameOverScreen.SetUp(scoreK, scoreM);
            //Application.LoadLevel(loadMenu);
            
        }

        
        if (transform.position.x < -7.7750f || transform.position.y < -4.066806f)
        {
            t2 -= Time.deltaTime;
            while (t2 < 0)
            {

            transform.position = new Vector2(-7.7729f, -3.066806f);
            DelVita(25);
            t2 = 2f;
            }
            
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "plat")
        {
            Destroy(other.gameObject);
        }
        if(health>=1 && health<=100){//se la vita è maggiore di un certo valore, allora tutto normale
            if(other.gameObject.tag=="good")
            {
                AddScore(25);
                t1 =50;//ogni volta che il personaggio mangia il timer si resetta 
            }

            if (other.gameObject.tag =="bad")
            {
                DelVita(25);
                t1=50;//ogni volta che il personaggio mangia il timer si resetta
            }

            if (other.gameObject.tag =="god")
            {
                //DelScore();
                float ripristino=maxhealth-healtCurrent;
                AddScore(ripristino);
                t1=50;//ogni volta che il personaggio mangia, il timer si resetta 
            }

            if (other.gameObject.tag =="water")
            {
                AddScore(25);
                t1=50;//ogni volta che il personaggio mangia, il timer si resetta 
            }
        }
    }

    void AddScore(float a)//aggiungi il punteggio specificato dalla variabile a e, inoltre, in base alla percentuale della vita, aggiorna il colore della barra
    {
        if(health>0 && health!=100 && (health+a)<=100){
            health +=a;
            
            healtCurrent = (health * barWidth) / maxhealth;
            healthBar.rectTransform.sizeDelta = new Vector2(healtCurrent, barHeight);

            if(health>75 && health<=100){
                    healthBar.GetComponent<Image>().color = new Color32(35,255,0,255);//verde
            }
            if(health>50 && health<=75){
                    healthBar.GetComponent<Image>().color = new Color32(255,128,0,255);//arancione
            }

            if(health>0 && health<=50){
                    healthBar.GetComponent<Image>().color = new Color32(255,0,0,255);//rosso
            }
        }
    }

    void DelVita(float b)//DECREMENTA la vita del personaggio quando entra in collisione con cibi non sani
    {
        
        health -=b;
        if (health>75){
            healtCurrent = (health * barWidth) / maxhealth;
            healthBar.rectTransform.sizeDelta = new Vector2(healtCurrent, barHeight);
        }

        if(health>50 && health<=75){
            healthBar.GetComponent<Image>().color = new Color32(255,128,0,255);//arancione
            healtCurrent = (health * barWidth) / maxhealth;
            healthBar.rectTransform.sizeDelta = new Vector2(healtCurrent, barHeight);

        }

        if(health>0 && health<=50){
            healthBar.GetComponent<Image>().color = new Color32(255,0,0,255);//rosso
            healtCurrent = (health * barWidth) / maxhealth;
            healthBar.rectTransform.sizeDelta = new Vector2(healtCurrent, barHeight);

        }
        if(health<=0){
            health=0;
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }



}