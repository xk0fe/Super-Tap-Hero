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

    public static int ScreenTap; //to understand how many times user tapped a screen

    public static bool CoinCollected1, CoinCollected2, CoinCollected3; //check if coin is collected

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        animator.SetFloat("Speed", rb.velocity.y);
        animator.SetBool("OnGround", onGround);
        RunningFunc();
    }

    void RunningFunc()
    {
        if (ScreenTap >= 1)
        {
            MoveRight(); //Move.cs
        }
    }

    public void JumpFunc()
    {
        if(ScreenTap == 0) //player making a first tap
        {
            ScreenTap++;
            JumpHigh(); //Move.cs
        }
        else if (onGround && ScreenTap >= 1) //all other taps
        {
            ScreenTap++;
            JumpHigh(); //Move.cs
        }
    }


    void OnTriggerEnter2D(Collider2D other) //every coin has it own tag because is it easier to use individual tags instead of a proper code in a small game
    {
        if (other.gameObject.tag == "Coin1")
        {
            CoinCollected1 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Coin2")
        {
            CoinCollected2 = true;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Coin3")
        {
            CoinCollected3 = true;
            other.gameObject.SetActive(false);
        }
    }
}
