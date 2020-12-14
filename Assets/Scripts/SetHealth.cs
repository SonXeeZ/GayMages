using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHealth : MonoBehaviour
{
    public Slider healthBar;
    

    private void Update()
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();
        healthBar.value = jatekos.jatekosElet;
    }
}
