using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : Move
{
    public Animator animator;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public bool playerDead;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        animator.SetBool("Dead", playerDead);
        animator.SetBool("OnGround", onGround);
        animator.SetFloat("Speed", rb.velocity.y);
        RunningFunc();
    }

    void RunningFunc()
    {
        if (SceneBoss.ScreenTap >= 1)
        {
            MoveRight(); //Move.cs
        }
    }

    public void JumpFunc()
    {
        if(SceneBoss.ScreenTap == 0) //player making a first tap
        {
            SceneBoss.ScreenTap++;
            JumpHigh(); //Move.cs
        }
        else if (onGround && SceneBoss.ScreenTap >= 1) //all other taps
        {
            SceneBoss.ScreenTap++;
            JumpHigh(); //Move.cs
        }
    }


    void OnTriggerEnter2D(Collider2D other) //every star has it own tag because is it easier to use individual tags instead of a proper code in a small game
    {
        if (other.gameObject.name == "ColStar1")
        {
            SceneBoss.StarCollected1 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Star2")
        {
            SceneBoss.StarCollected2 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Star3")
        {
            SceneBoss.StarCollected3 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "DeathTag")
        {
            playerDead = true;
            StopMovement();
        }
    }

    void StarFucking()
    {
        
        
    }
}
