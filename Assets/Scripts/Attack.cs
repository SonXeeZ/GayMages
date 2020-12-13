using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public GameObject jatekos;
    float attackIdo = 0f;


    public Animator animatorThief;
    public Animator animatorMage;
    public Animator animatorWarrior;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask vaseLayers;

    public int attackDamage = 20;





    void Start()
    {
        // j1 -> dmg 5
        // j2 -> dmg 10
        // j3    dmg 20
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && attackIdo == 0f)
        {
            Tamadas();
            attackIdo += 1.0f;
        }
        if (Input.GetMouseButtonUp(0))
        {
            animatorWarrior.SetBool("isAttacking", false);
        }
        AttackIdo();
    }

    void Tamadas()
    {
        animatorWarrior.SetBool("isAttacking", true);

        Collider2D[] hitVases = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, vaseLayers);

        foreach (Collider2D enemy in hitVases)
        {
            enemy.GetComponent<Vase>().TakeDamage(attackDamage);
        }
    }

    void AttackIdo()
    {
        if (attackIdo > 0f)
        {
            attackIdo -= Time.fixedDeltaTime;
            if (attackIdo <= 0f)
            {
                attackIdo = 0f;
            }
        }
    }
}
