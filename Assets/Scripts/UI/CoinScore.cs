using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    
    

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
            DeusEx.CoinCount++;
            this.gameObject.SetActive(false);
        }
    }
}
