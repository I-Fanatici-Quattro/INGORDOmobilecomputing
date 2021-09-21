using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class BackGroundMove : MonoBehaviour
{
    public Score v;
    public int velocitaTerreno = 10;
    bool ver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (velocitaTerreno*Time.deltaTime,0,0);
        if(transform.position.x <= -21.49)
        {
            transform.position =new Vector3(21.49f,transform.position.y,3);
        }

        if(v.health <=50 && ver == false)
        {
            ver = true;
            velocitaTerreno -= 2;
        }

        if (v.health > 50 && ver == true)
        {
            ver = false;
            velocitaTerreno += 2;
        }

    }
}
