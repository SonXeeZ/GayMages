using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterValtas : MonoBehaviour
{
    public GameObject jatekos1, jatekos2, jatekos3;
    public sbyte melyikKarakter;
    Vector3 pozicio;

    void Start()
    {
        melyikKarakter = 1;
        jatekos1.gameObject.SetActive(true);
        jatekos2.gameObject.SetActive(false);
        jatekos3.gameObject.SetActive(false);
        //jelenlegiKarakter(1);
    }

    void Update()
    {
        switchKarakter();
        if(melyikKarakter == 1)
        {
            pozicio = jatekos1.transform.position;
        }
        else if (melyikKarakter == 2)
        {
            pozicio = jatekos2.transform.position;
        }
        else if (melyikKarakter == 3)
        {
            pozicio = jatekos3.transform.position;
        }

    }
    void switchKarakter()
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if (Input.GetKeyDown("1") && melyikKarakter != 1)
        {
            melyikKarakter = 1;
            jatekos1.gameObject.SetActive(true);
            jatekos2.gameObject.SetActive(false);
            jatekos3.gameObject.SetActive(false);
            // Teleport
            jatekos1.transform.position = pozicio;
            // Sebesseg
            jatekos.sebesseg = 3.0f;

        }
        else if (Input.GetKeyDown("2") && melyikKarakter != 2)
        {
            melyikKarakter = 2;
            jatekos1.gameObject.SetActive(false);
            jatekos2.gameObject.SetActive(true);
            jatekos3.gameObject.SetActive(false);

            jatekos2.transform.position = pozicio;
            // Sebesseg
            jatekos.sebesseg = 2.0f;

        }
        else if (Input.GetKeyDown("3") && melyikKarakter != 3)
        {
            melyikKarakter = 3;
            jatekos1.gameObject.SetActive(false);
            jatekos2.gameObject.SetActive(false);
            jatekos3.gameObject.SetActive(true);
            jatekos3.transform.position = pozicio;
            // Sebesseg
            jatekos.sebesseg = 2.0f;

        }
    }
    /*private int jelenlegiKarakter(int karakter)
    {
        if (Input.GetKeyDown("1")){
            karakter = 1;
        }
        else if (Input.GetKeyDown("2")){
            karakter = 2;
        }
        else if (Input.GetKeyDown("3")){
            karakter = 3;
        }
        return karakter;
    }   */

   
}

