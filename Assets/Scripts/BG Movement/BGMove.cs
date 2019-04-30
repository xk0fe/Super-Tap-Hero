using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public void Clouds()
    {
        rb.velocity = new Vector2(-1, rb.velocity.y);
    }

    public void CloudsAlt()
    {
        rb.velocity = new Vector2(-1.5f, rb.velocity.y);
    }

    public void Sun()
    {
        rb.velocity = new Vector2(-.3f, rb.velocity.y);
    }
}
