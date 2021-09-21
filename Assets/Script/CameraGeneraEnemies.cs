using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Applicare questo script alla camera per far si che vangano visualizzati i punteggi fatti dal giocatore sullo schermo durante il gioco*/
public class CameraGeneraEnemies : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public GameObject bulletPrefab;
    public GameObject ciboPrefab;
    public GameObject AltroPrefab;
    public GameObject Bobs;
    public GameObject water;
    public GameObject platform;
    public GameObject melanzana;
    public GameObject carne;
    public GameObject uva;
    public GameObject pollo;
    public GameObject lecca;

    public MoviementoEnemy mov;
    public Score s;

    //booleani per autorizzare la creazione dei cibi da inviare

    bool a1=false;
    bool b1=false;
    bool c1=false;
    bool d1=false;
    bool e1=false;
    bool g1=false;
    bool h1=false;
    bool i1=false;
    bool l1=false;
    bool m1=false;
    bool w1=false;

    float respawnGeneral=5f;
    
    
    /////////

    float respawnTime = 1.0f;
    private Vector2 screenBounds;
   
     float respawnDueTime = 2.0f;
    private Vector2 screenBoundsDue;

    
     float respawnTreTime = 3.0f;
    private Vector2 screenBoundsTre;

     float respawnQuattroTime = 4.5f;
    private Vector2 screenBoundsQuattro;

     float respawnCinqueTime =50f;
    private Vector2 screenBoundsCinque;//fagiolo di balzar
    public Score h;

    float respawnSeiTime =20f;
    private Vector2 screenBoundsSei;

 
    private Vector2 screenBoundsSette;

    private Vector2 screenBoundsOtto;

    private Vector2 screenBoundsNove;

    private Vector2 screenBoundsDieci;

    private Vector2 screenBoundsUndici;

    private Vector2 screenBoundsDodici;



    // Start is called before the first frame update
    void Start()
    {
        screenBoundsDue = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveDue());
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());

        screenBoundsTre = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveTre());

        screenBoundsQuattro = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveQuattro());

        screenBoundsCinque = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveCinque());

        screenBoundsSei = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveSei());

        screenBoundsSette = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveSette());

        screenBoundsOtto = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveOtto());

        screenBoundsNove = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveNove());

        screenBoundsDieci = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveDieci());

        screenBoundsUndici = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveUndici());

        screenBoundsDodici = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWaveDodici());
    }

    void Update()
    {
        if(s.health<=50 && mov.speed==10){
            mov.speed -= 4;
        }

        if (s.health > 50 && mov.speed != 10)
        {
            mov.speed += 4;
        }
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-1.5f, 3.5f));
    }

    private void spawnEnemyDue()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = new Vector2(screenBoundsDue.x * 2, Random.Range(-1.5f, 3.5f));
    }

      private void spawnEnemyTre()
    {
        GameObject c = Instantiate(ciboPrefab) as GameObject;
        c.transform.position = new Vector2(screenBoundsTre.x * 2, Random.Range(-1.5f, 3.5f));
    }

    private void spawnEnemyQuattro()
    {
        GameObject d = Instantiate(AltroPrefab) as GameObject;
        d.transform.position = new Vector2(screenBoundsQuattro.x * 2, Random.Range(-1.5f, 3.5f));
    }

    private void spawnEnemyCinque()//fagiolo di balzar
    {
        GameObject e = Instantiate(Bobs) as GameObject;
        e.transform.position = new Vector2(screenBoundsCinque.x * 2, Random.Range(3f,3.4f));
    }

    private void spawnEnemySei()//acqua
    {
        GameObject f = Instantiate(water) as GameObject;
        f.transform.position = new Vector2(screenBoundsCinque.x * 2, Random.Range(2f,3.4f));
    }

    private void spawnEnemySette()//piattaforma
    {
        GameObject g = Instantiate(platform) as GameObject;
        g.transform.position = new Vector2(screenBoundsSette.x * 2, Random.Range(0.6f, 1f));
    }
    
    private void spawnEnemyOtto()
    {
        GameObject h = Instantiate(melanzana) as GameObject;
        h.transform.position = new Vector2(screenBoundsOtto.x * 2, Random.Range(0.6f, 1f));
    }
    
    private void spawnEnemyNove()
    {
        GameObject i = Instantiate(carne) as GameObject;
        i.transform.position = new Vector2(screenBoundsNove.x * 2, Random.Range(0.6f, 1f));
    }
    
    private void spawnEnemyDieci()
    {
        GameObject l = Instantiate(uva) as GameObject;
        l.transform.position = new Vector2(screenBoundsDieci.x * 2, Random.Range(0.6f, 1f));
    }
    
    private void spawnEnemyUndici()
    {
        GameObject m = Instantiate(pollo) as GameObject;
        m.transform.position = new Vector2(screenBoundsUndici.x * 2, Random.Range(0.6f, 1f));
    }
    
    private void spawnEnemyDodici()
    {
        GameObject n = Instantiate(lecca) as GameObject;
        n.transform.position = new Vector2(screenBoundsDodici.x * 2, Random.Range(0.6f, 1f));
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,8);
            yield return new WaitForSeconds(respawnGeneral);
            if(b1==false && c1==false && d1==false && e1==false && g1==false && h1==false && i1==false && l1==false && m1==false){
                a1=true;
                yield return new WaitForSeconds(respawnTime+(Random.Range(respawnTime+1, respawnTime+3)));
                spawnEnemy();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                a1 =false;
            }
        }
    }

    IEnumerator asteroidWaveDue()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,8);
            yield return new WaitForSeconds(respawnGeneral);
            if(a1==false && c1==false && d1==false && e1==false && g1 == false && h1 == false && i1 == false && l1 == false && m1 == false)
            {
                b1=true;
                respawnDueTime = Random.Range(respawnTime+2, respawnTime+3);
                yield return new WaitForSeconds(respawnDueTime);
                spawnEnemyDue();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemy();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                b1 =false;
            }
        }
    }

    IEnumerator asteroidWaveTre()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,8);
            yield return new WaitForSeconds(respawnGeneral);
             if(a1==false && b1==false && d1==false && e1==false && g1 == false && h1 == false && i1 == false && l1 == false && m1 == false)
            {
                c1=true;
                respawnTreTime = Random.Range(respawnDueTime+3, respawnDueTime+5);
                yield return new WaitForSeconds(respawnTreTime);
                spawnEnemyTre();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemy();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                c1 =false;
            }
        }
    }

    IEnumerator asteroidWaveQuattro()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,8);
            yield return new WaitForSeconds(respawnGeneral);
             if(a1==false && b1==false && c1==false && e1==false && g1 == false && h1 == false && i1 == false && l1 == false && m1 == false)
            {
                d1=true;
                respawnQuattroTime = Random.Range(respawnTreTime+3, respawnTreTime+4);
                yield return new WaitForSeconds(respawnQuattroTime);
                spawnEnemyQuattro();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemy();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                d1 =false;
            }
        }
    }

    

    IEnumerator asteroidWaveCinque()//fagiolo
    {
        while (true)
        {
            if(h.health<=49){
                yield return new WaitForSeconds(20f);
                spawnEnemyDue();  
            }

            //respawnCinqueTime = Random.Range(respawnCinqueTime+3, respawnCinqueTime+4);
            yield return new WaitForSeconds(respawnCinqueTime);
            spawnEnemyCinque();
        }
    }

    IEnumerator asteroidWaveSei()//acqua
    {
        while (true)
        {
            w1 = true;
            respawnSeiTime = Random.Range(respawnSeiTime+3, respawnSeiTime+4);
            yield return new WaitForSeconds(respawnSeiTime);
            spawnEnemySei();
            w1 = false;
        }
    }

    IEnumerator asteroidWaveSette()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,8);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == true || b1 == true || c1 == true || d1 == true || w1 == true || g1 == true || h1 == true || i1 == true || l1 == true || m1 == true)
            {
                e1 = true;
                yield return new WaitForSeconds(respawnGeneral+3);
                spawnEnemySette();
                e1 = false;
            }
        }
    }

    IEnumerator asteroidWaveOtto()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2, 8);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1==false && b1 == false && c1 == false && d1 == false && e1 == false && h1 == false && i1 == false && l1 == false && m1 == false)
            {
                g1 = true;
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 3)));
                spawnEnemyOtto();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                g1 = false;
            }
        }
    }

    IEnumerator asteroidWaveNove()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2, 8);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == false && b1 == false && c1 == false && d1 == false && e1 == false && g1 == false && i1 == false && l1 == false && m1 == false)
            {
                h1 = true;
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 3)));
                spawnEnemyNove();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                h1 = false;
            }
        }
    }

    IEnumerator asteroidWaveDieci()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2, 8);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == false && b1 == false && c1 == false && d1 == false && e1 == false && g1 == false && h1 == false && l1 == false && m1 == false)
            {
                i1 = true;
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 3)));
                spawnEnemyDieci();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                i1 = false;
            }
        }
    }

    IEnumerator asteroidWaveUndici()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2, 8);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == false && b1 == false && c1 == false && d1 == false && e1 == false && g1 == false && h1 == false && i1 == false && m1 == false)
            {
                l1 = true;
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 3)));
                spawnEnemyUndici();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                l1 = false;
            }
        }
    }

    IEnumerator asteroidWaveDodici()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2, 10);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == false && b1 == false && c1 == false && d1 == false && e1 == false && g1 == false && h1 == false && i1 == false && l1 == false)
            {
                m1 = true;
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 3)));
                spawnEnemyDodici();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemyCinque();
                if (respawnGeneral == 6)
                    spawnEnemyOtto();
                if (respawnGeneral == 7)
                    spawnEnemyNove();
                if (respawnGeneral == 8)
                    spawnEnemyDieci();
                if (respawnGeneral == 9)
                    spawnEnemyUndici();
                if (respawnGeneral == 10)
                    spawnEnemyDodici();
                m1 = false;
            }
        }
    }
}
