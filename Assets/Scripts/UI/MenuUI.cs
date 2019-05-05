using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Text AllCoinCountText;

    private void Update()
    {
        AllCoinCountText.text = LevelManager.CoinCount.ToString();
    }
    
}
