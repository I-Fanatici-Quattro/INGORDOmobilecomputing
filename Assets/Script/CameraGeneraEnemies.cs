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


    //booleani per autorizzare la creazione dei cibi da inviare

    bool a1=false;
    bool b1=false;
    bool c1=false;
    bool d1=false;
    bool e1=false;
    bool w1 = false;

    float respawnGeneral=5f;
    //bool e1=false;
    //bool f1=false;
    
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

    float respawnSetteTime = 15f;
    private Vector2 screenBoundsSette;



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

    IEnumerator asteroidWave()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,5);
            yield return new WaitForSeconds(respawnGeneral);
            if(b1==false && c1==false && d1==false && e1==false){
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
                a1 =false;
            }
        }
    }

    IEnumerator asteroidWaveDue()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,5);
            yield return new WaitForSeconds(respawnGeneral);
            if(a1==false && c1==false && d1==false && e1==false)
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
                b1 =false;
            }
        }
    }

    IEnumerator asteroidWaveTre()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,5);
            yield return new WaitForSeconds(respawnGeneral);
             if(a1==false && b1==false && d1==false && e1==false)
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
                c1 =false;
            }
        }
    }

    IEnumerator asteroidWaveQuattro()
    {
        while (true)
        {
            respawnGeneral = Random.Range(2,5);
            yield return new WaitForSeconds(respawnGeneral);
             if(a1==false && b1==false && c1==false && e1==false){
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
            respawnGeneral = Random.Range(2,6);
            yield return new WaitForSeconds(respawnGeneral);
            if (a1 == true || b1 == true || c1 == true || d1 == true || w1 == true){
                e1 = true;
                yield return new WaitForSeconds(6);
                spawnEnemySette();
                yield return new WaitForSeconds(respawnTime + (Random.Range(respawnTime + 1, respawnTime + 2)));
                if (respawnGeneral == 2)
                    spawnEnemyDue();
                if (respawnGeneral == 3)
                    spawnEnemyTre();
                if (respawnGeneral == 4)
                    spawnEnemyQuattro();
                if (respawnGeneral == 5)
                    spawnEnemy();
                e1 = false;
            }
        }
    }
}
