using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    //public GameObject kulcsKek,kulcsZold,kulcsLila;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if (other.gameObject.tag == "kulcsKek")
        {
            Debug.Log("Felvettél egy kulcsot.");
            jatekos.kulcsKek++;
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.tag == "kulcsZold")
        {
            Debug.Log("Felvettél egy kulcsot.");
            jatekos.kulcsZold++;
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "kulcsLila")
        {
            Debug.Log("Felvettél egy kulcsot.");
            jatekos.kulcsLila++;
            Destroy(other.gameObject);

        }
    }




}
