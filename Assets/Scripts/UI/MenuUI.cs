using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Text AllCoinCountText;

    void Update()
    {
        AllCoinCountText.text = SceneBoss.CoinCount.ToString();
    }

}
