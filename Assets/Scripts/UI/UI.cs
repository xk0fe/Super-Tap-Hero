using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text AllCoinCountText;

    void Update()
    {
        AllCoinCountText.text = SceneBoss.CoinCount.ToString();
    }

    void PlayLevel()
    {

    }

}
