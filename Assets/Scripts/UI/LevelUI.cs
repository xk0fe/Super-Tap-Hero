using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    public SceneBoss parent;

    public GameObject pauseButton;
    public GameObject TapIcon;
    [Header("Coin score")]
    public Text LevelCoinCountText;
    public Text LevelCompleteCoinCountText;
    [Header("UI sprite states")]
    public Sprite SilverStar; //if coin is NOT collected
    public Sprite GoldStar; //if coin is collected
    [Header("UI elements")]
    public GameObject smallStar1;
    public GameObject smallStar2;
    public GameObject smallStar3;
    public GameObject bigStar1;
    public GameObject bigStar2;
    public GameObject bigStar3;

    // Update is called once per frame
    void Update()
    {
        ChangeUIicons();
        LevelCoinCountText.text = parent.LevelCoinCount.ToString(); //showing coin count while playing
        LevelCompleteCoinCountText.text = parent.LevelCoinCount.ToString(); //showing coin coint count on a "level complete" screen

        
    }

    public void TapCheck()
    {
        if (SceneBoss.ScreenTap == 0) //no taps
        {
            TapIcon.SetActive(true); //show TAP icon
        }
        else //player tapped
        {
            pauseButton.SetActive(true); //show PAUSE button
            TapIcon.SetActive(false); //disable TAP icon
        }
    }

    void ChangeUIicons() //changes a sprite if coin is collected 
    {
        if (SceneBoss.StarCollected1 == 1)
        {
            smallStar1.GetComponent<Image>().sprite = GoldStar;
            bigStar1.GetComponent<Image>().sprite = GoldStar;
        }
        if (SceneBoss.StarCollected2 == 1)
        {
            smallStar2.GetComponent<Image>().sprite = GoldStar;
            bigStar2.GetComponent<Image>().sprite = GoldStar;
        }
        if (SceneBoss.StarCollected3 == 1)
        {
            smallStar3.GetComponent<Image>().sprite = GoldStar;
            bigStar3.GetComponent<Image>().sprite = GoldStar;
        }
    }
}
