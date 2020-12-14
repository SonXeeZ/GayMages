using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegen : MonoBehaviour
{
    public float mennyiHP = 20.0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        

        if (other.gameObject.tag == "HP")
        {
            jatekos.jatekosElet += mennyiHP;
            Destroy(other.gameObject);
            Debug.Log("+20 HP!");
            if (jatekos.jatekosElet > 100)
            {
                jatekos.jatekosElet = 100;
                Debug.Log("Több volt mint 100HP.");
            }
        }
        
    }
}
