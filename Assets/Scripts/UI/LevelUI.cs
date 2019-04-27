using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    public GameObject RepeatButton;
    public GameObject TapIcon;
    public Text LevelCoinCountText;
    public SceneBoss parent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCoinCountText.text = parent.LevelCoinCount.ToString();

        if (SceneBoss.ScreenTap == 0) //show TAP icon if player has not tapped
        {
            RepeatButton.SetActive(false);
            TapIcon.SetActive(true);
        }
        else //hide TAP icon if player has tapped
        {
            RepeatButton.SetActive(true);
            TapIcon.SetActive(false);
        }
    }
}
