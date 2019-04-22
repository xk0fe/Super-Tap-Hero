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
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        else if (onGround && ScreenTap >= 1)
        {
            ScreenTap++;
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
    }

    void RunningFunc()
    {
        if (ScreenTap >= 1)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
    }
}
