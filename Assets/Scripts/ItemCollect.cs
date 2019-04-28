using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public LevelUI parent;

    void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.gameObject.tag == "Coin")
        {
            parent.parent.LevelCoinCount++; //add coin - ItemCollect : LevelUI : SceneBoss
            coin.gameObject.SetActive(false); //destroy coin
        }
    }
}
