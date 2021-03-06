﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjtoNyitas : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if (collision.gameObject.tag == "ajtoKek" && jatekos.kulcsKek == 1)
        {
            jatekos.kulcsKek = 0;
            Destroy(collision.gameObject);
            Debug.Log("Ajtó nyitva.");
        }
        if (collision.gameObject.tag == "ajtoZold" && jatekos.kulcsZold == 1)
        {
            jatekos.kulcsZold = 0;
            Destroy(collision.gameObject);
            Debug.Log("Ajtó nyitva.");
        }
        if (collision.gameObject.tag == "ajtoLila" && jatekos.kulcsLila == 1)
        {
            jatekos.kulcsLila = 0;
            Destroy(collision.gameObject);
            Debug.Log("Ajtó nyitva.");
        }
    }
}
