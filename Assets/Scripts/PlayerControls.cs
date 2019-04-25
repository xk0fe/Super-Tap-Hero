using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public int ScreenTap; //to understand how many times user tapped a screen

    public static bool CoinCollected1, CoinCollected2, CoinCollected3; //check if coin is collected

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        animator.SetBool("OnGround", onGround);
        animator.SetFloat("Speed", rb.velocity.y);

        RunningFunc();
    }

    public void JumpFunc()
    {
        if(ScreenTap == 0) //player making a first tap
        {
            ScreenTap++;
            rb.velocity = new Vector2(rb.velocity.x, 5); //jumping
        }
        else if (onGround && ScreenTap >= 1) //all other taps
        {
            ScreenTap++;
            rb.velocity = new Vector2(rb.velocity.x, 5); //jumping
        }
    }

    void RunningFunc()
    {
        if (ScreenTap >= 1)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
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
