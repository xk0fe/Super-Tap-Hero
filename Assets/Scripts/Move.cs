using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;

    public void MoveRight()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-3, rb.velocity.y);
    }
}
