using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Pavimento3 : MonoBehaviour
{   
    public Score v;
    bool ver=false;
    bool vel = false;
    float tempo=10f;//durta dell'aumento velocità del terreno
    public int velocitaTerreno = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        transform.position -= new Vector3 (velocitaTerreno*Time.deltaTime,0,0);
        if(transform.position.x <= -3.32)
        {
            transform.position =new Vector3(48.33f,transform.position.y,0f);
        }
        if (v.health<100 && velocitaTerreno!=15 )
        {//arrivato a 5 km  la velocità del pavimento aumenta
            ver = true;
            velocitaTerreno += 5;

        }

        while (tempo<0)
        {
            if (ver)
            {
                velocitaTerreno = 10;
                ver = false;
            }
            tempo = 10;
        }
    }
}
