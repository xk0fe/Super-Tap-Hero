using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimple : Move
{
    public Animator animator;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public GameObject MainObject;
    public GameObject Player;

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
        MoveLeftSlow();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MainObject.GetComponent<DeusEx>().RepeatButtonFunc();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
