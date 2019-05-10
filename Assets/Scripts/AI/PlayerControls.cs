using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : Move
{
    public Transform groundCheck;
    public bool onGround;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        animator.SetBool("OnGround", onGround);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        RunningFunc();
    }

    void RunningFunc()
    {
        if (LevelManager.ScreenTap >= 1)
        {
            MoveRight(); //Move.cs
        }
    }

    public void JumpFunc()
    {
        if(LevelManager.ScreenTap == 0) //player making a first tap
        {
            LevelManager.ScreenTap++;
            JumpHigh(); //Move.cs
        }
        else if (onGround && LevelManager.ScreenTap >= 1) //all other taps
        {
            LevelManager.ScreenTap++;
            JumpHigh(); //Move.cs
        }
    }


    void OnTriggerEnter2D(Collider2D collision) //every star has it own tag because is it easier to use individual tags instead of a proper code in a small game
    {
        if (collision.gameObject.name == "ColStar1")
        {
            LevelManager.StarCollected1 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "ColStar2")
        {
            LevelManager.StarCollected2 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "ColStar3")
        {
            LevelManager.StarCollected3 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "DeathTag")
        {
            isDead = true;
            StopMovement();
        }
    }
}
