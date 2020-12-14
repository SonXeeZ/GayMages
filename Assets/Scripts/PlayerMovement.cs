using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
        
    public float sebesseg = 3.0f;
    public float jatekosElet = 100f;

    public sbyte kulcsKek, kulcsZold, kulcsLila;

    public Rigidbody2D rb;
    public Camera cam;

    // ANIMATORS
    public Animator animatorThief;
    public Animator animatorMage;
    public Animator animatorWarrior;
    
    Vector2 movement;
    Vector2 mousePos;


    private void Start()
    {
        kulcsKek = 0;
        kulcsZold = 0;
        kulcsLila = 0;
    }
    // Update is called once per frame
    void Update()
    {
      
        if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            animatorThief.SetBool("isMoving", true);
            animatorMage.SetBool("isMoving", true);
            animatorWarrior.SetBool("isMoving", true);

        }
        if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        {
            animatorThief.SetBool("isMoving", false);
            animatorMage.SetBool("isMoving", false);
            animatorWarrior.SetBool("isMoving", false);
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Death();
    }
    private void FixedUpdate()
    {
        Sebesseg(sebesseg);
    }


    public float Sebesseg(float moveSpeed)
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        return moveSpeed;
    }

    void Death()
    {
        if(jatekosElet <= 0)
        {
            SceneManager.LoadScene("Dungeon");
        }
    }

    
}


