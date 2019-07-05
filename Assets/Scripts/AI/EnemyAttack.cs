using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : Move
{
    public GameObject MainObject; //SceneBoss itself

    void FixedUpdate()
    {
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
            IsDead = true;
            DisableGameObject();
        }
    }
}
