using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public Sprite SilverCoin; //if coin is NOT collected
    public Sprite GoldCoin; //if coin is collected
    public GameObject Coin1, Coin2, Coin3; //UI element
    public bool CoinCollected1, CoinCollected2, CoinCollected3; //check if coin is collected (child, depends on a parent)

    public PlayerControls parent; //linking

    void Update()
    {
        CoinVarSettings(); //setting local variables equal to a parent variables
        ChangeUIicons();
    }

    void ChangeUIicons() //changes a sprite if coin is collected 
    {
        if (CoinCollected1 == true)
        {
            Coin1.GetComponent<Image>().sprite = GoldCoin;
        }
        if (CoinCollected2 == true)
        {
            Coin2.GetComponent<Image>().sprite = GoldCoin;
        }
        if (CoinCollected3 == true)
        {
            Coin3.GetComponent<Image>().sprite = GoldCoin;
        }
    }

    void CoinVarSettings() //setting local variables equal to a parent variables
    {
        CoinCollected1 = parent.CoinCollected1;
        CoinCollected2 = parent.CoinCollected2;
        CoinCollected3 = parent.CoinCollected3;
    }
}
