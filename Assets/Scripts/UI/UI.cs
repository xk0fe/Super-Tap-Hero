using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject RepeatButton;
    public GameObject TapButton;
    public Text countText;


    void Update()
    {
        countText.text = DeusEx.CoinCount.ToString();

        if (DeusEx.ScreenTap == 0) //show TAP icon if player has not tapped
        {
            RepeatButton.SetActive(false);
            TapButton.SetActive(true);
        }
        else //hide TAP icon if player has tapped
        {
            RepeatButton.SetActive(true);
            TapButton.SetActive(false);
        }
    }

}
