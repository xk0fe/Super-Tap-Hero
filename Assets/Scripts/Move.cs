using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    public bool isDead;
    public bool onGround;

    public LayerMask whatIsGround = 1<<8;
    public float groundCheckRadius = 0f;

    public void MoveRight()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
    }

    public void Update()
    {
        animator.SetBool("OnGround", onGround);
        animator.SetBool("Dead", isDead);
        animator.SetFloat("Speed", rb.velocity.x);
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-3, rb.velocity.y);
    }

    public void MoveLeftSlow()
    {
        rb.velocity = new Vector2(-2, rb.velocity.y);
    }

    public void JumpHigh() //called High so there is no confusion with JumpFunc();
    {
        rb.velocity = new Vector2(rb.velocity.x, 7.4f);
    }

    public void StopMovement()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void EnemyDead()
    {
        rb.isKinematic = true;
        rb.velocity = new Vector2(rb.velocity.x, -3);
    }
}
