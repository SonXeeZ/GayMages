using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject targy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if (other.gameObject.tag == "Kulcs")
        {
            jatekos.kulcsDarab++;
            Destroy(other.gameObject);
            
        }
    }




}
