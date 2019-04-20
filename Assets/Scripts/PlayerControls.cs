using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Transform groundCheck;
    //public Transform startPosition;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    private bool Running; //to understand if the player is running
    public int ScreenTap; //to understand how many times user tapped a screen

    public GameObject TapIcon;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        animator.SetBool("OnGround", onGround);
        animator.SetFloat("Speed", rb.velocity.y);

        FirstTap();
        RunningFunc();
        JumpFunc();
    }

    void FirstTap()
    {
        if (Input.GetMouseButtonDown(0) && ScreenTap == 0)
        {
            Destroy(TapIcon);
            ScreenTap++;
            rb.velocity = new Vector2(rb.velocity.x, 2);         
        }
    }

    void JumpFunc()
    {
        if (Input.GetMouseButtonDown(0) && onGround && ScreenTap >= 1)
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
