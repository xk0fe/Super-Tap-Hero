using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Text AllCoinCountText;
    public Text StatTotalCoins;

    private void Update()
    {
        AllCoinCountText.text = LevelManager.CoinCount.ToString();
        StatTotalCoins.text = LevelManager.CoinCount.ToString();
    }
    
}
