using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kulcs_UI : MonoBehaviour
{
    
    public Image kulcs1,kulcs2,kulcs3;

    private void Awake()
    {
        kulcs1.enabled = false;
        kulcs2.enabled = false;
        kulcs3.enabled = false;
    }
    void Update()
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if(jatekos.kulcsKek == 1)
        {
            kulcs1.enabled = true;
        }
        if(jatekos.kulcsZold == 1)
        {
            kulcs2.enabled = true;
        }
        if(jatekos.kulcsLila == 1)
        {
            kulcs3.enabled = true;
        }
    }

}