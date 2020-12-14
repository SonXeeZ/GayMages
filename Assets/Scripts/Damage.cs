using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
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
        KarakterValtas karakter = FindObjectOfType<KarakterValtas>();
        sbyte jelenlegiKarakter = karakter.melyikKarakter;

        if (collision.gameObject.tag == "Spike")
        {
            if (szamlalo % animGyakorisag == 0.0f)
            {
                jatekos.jatekosElet -= 10;
                szamlalo = 0.0f;
                Debug.Log("-100 élet!");
            }
            
        }
        if (szamlalo % animGyakorisag == 0.0f)
        {
            if (collision.gameObject.tag == "toxicMezo")
            {
                jatekos.jatekosElet -= 5;
                szamlalo = 0.0f;
                Debug.Log("-5 élet!");
            }

        }
        /*
        if (collision.gameObject.tag == "toxicMezo")
        {
            jatekos.sebesseg = 1.0f;
        }
        else if (collision.gameObject.tag == null)
        {
            if (karakter.melyikKarakter == 1)
            {
                jatekos.sebesseg = 3.0f;
            }
            else if (karakter.melyikKarakter == 2)
            {
                jatekos.sebesseg = 2.0f;
            }
            else if (karakter.melyikKarakter == 3)
            {
                jatekos.sebesseg = 2.0f;
            } */
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        KarakterValtas karakter = FindObjectOfType<KarakterValtas>();
        if(collision.gameObject.tag =="toxicMezo")
        jatekos.sebesseg = 1.0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        KarakterValtas karakter = FindObjectOfType<KarakterValtas>();
        

        if (collision.gameObject.tag == "toxicMezo")
        {
            if (karakter.melyikKarakter == 1)
            {
                jatekos.sebesseg = 3.0f;
            }
            else if (karakter.melyikKarakter == 2)
            {
                jatekos.sebesseg = 2.0f;
            }
            else if (karakter.melyikKarakter == 3)
            {
                jatekos.sebesseg = 2.0f;
            }
        }
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
