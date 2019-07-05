using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.gameObject.tag == "Coin")
        {
            LevelManager.LevelCoinCount++;      //add coin
            coin.gameObject.SetActive(false);   //and destroy
        }
    }
}

