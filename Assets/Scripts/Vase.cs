using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vase : MonoBehaviour
{
    
    public Animator vase;
    bool szettortE = false;

    public int maxHealth = 10;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0 && szettortE == false)
        {
            vaseBreak();
            this.GetComponent<CircleCollider2D>().enabled = false;
        }
    }

    void vaseBreak()
    {
        vase.SetBool("isBroken", true);
        szettortE = true;
        Debug.Log("Vase broke!");
    }
}
