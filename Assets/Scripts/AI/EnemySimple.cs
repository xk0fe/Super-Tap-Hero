using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimple : Move
{
    public Transform groundCheck;

    public GameObject MainObject; //SceneBoss itself
    public GameObject Player;

    public static int ScreenTap; //to understand how many times user tapped a screen

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        MoveLeftSlow();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MainObject.GetComponent<LevelManager>().RestartLevel();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "DeathTag")
        {
            isDead = true;
            DisableGameObject();
        }
    }
}
