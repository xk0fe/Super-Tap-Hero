using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public Sprite SilverCoin; //if coin is NOT collected
    public Sprite GoldCoin; //if coin is collected
    public GameObject Coin1, Coin2, Coin3; //UI element

    void Update()
    {
        ChangeUIicons();
    }

    void ChangeUIicons() //changes a sprite if coin is collected 
    {
        if (PlayerControls.CoinCollected1 == true)
        {
            Coin1.GetComponent<Image>().sprite = GoldCoin;
        }
        if (PlayerControls.CoinCollected2 == true)
        {
            Coin2.GetComponent<Image>().sprite = GoldCoin;
        }
        if (PlayerControls.CoinCollected3 == true)
        {
            Coin3.GetComponent<Image>().sprite = GoldCoin;
        }
    }
}
