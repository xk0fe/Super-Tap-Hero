using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{

    public SceneBoss parent;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) //every star has it own tag because is it easier to use individual tags instead of a proper code in a small game
    {
        if (other.gameObject.tag == "Player")
        {
            parent.LevelCoinCount++;
            this.gameObject.SetActive(false);
        }
    }
}
