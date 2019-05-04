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
            LevelManager.LevelCoinCount++; //add coin - ItemCollect : LevelUI : MenuUI : SceneBoss
            coin.gameObject.SetActive(false); //destroy coin
        }
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Space key was pressed.");
        }
    }
}

