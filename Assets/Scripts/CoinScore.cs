using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public Sprite SilverCoin;
    public Sprite GoldCoin;
    public GameObject Coin1, Coin2, Coin3;
    public bool CoinCollected1, CoinCollected2, CoinCollected3;

    void Update()
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

}
