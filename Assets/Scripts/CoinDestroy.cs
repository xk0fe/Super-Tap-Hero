using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{

    void OnTriggernEnter(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Destroy(this);
        }
    }

    void Update()
    {
        
    }
}
