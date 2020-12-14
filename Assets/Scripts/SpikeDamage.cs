using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    private float sebzesIdo;


    private float szamlalo = 0.0f;
    private float animGyakorisag = 100.0f;

    private void FixedUpdate()
    {
        szamlalo += 1.0f;
        
    }
    /*void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sebzés!");
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        if(szamlalo % 3.0f == 0.0f)
        {
            jatekos.jatekosElet -= 100;
            szamlalo = 0.0f;
        }

        //   jatekos.jatekosElet -= 100f;
    }*/

    void OnTriggerStay2D(Collider2D collision)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        if (szamlalo % animGyakorisag == 0.0f)
        {
            jatekos.jatekosElet -= 10;
            szamlalo = 0.0f;
            Debug.Log("-100 élet!");
        }

        //   jatekos.jatekosElet -= 100f;
    }

    /*void Sebzes()
    {
        sebzesIdo += Time.deltaTime;
        if (sebzesIdo <= 0f)
        {
            sebzesIdo = 0f;
        }
    
    }*/
}
