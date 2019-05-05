using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : LevelCharacterSwitch
{
    public GameObject pauseButton;
    public GameObject restartButton;
    public GameObject tapIcon;
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
        LevelCoinCountText.text = LevelManager.LevelCoinCount.ToString(); //showing coin count while playing
        LevelCompleteCoinCountText.text = LevelManager.LevelCoinCount.ToString(); //showing coin coint count on a "level complete" screen
    }

    public void TapCheck()
    {
        if (LevelManager.ScreenTap == 0) //no taps
        {
            tapIcon.SetActive(true); //show TAP icon
        }
        else //player tapped
        {
            pauseButton.SetActive(true); //show PAUSE button
            tapIcon.SetActive(false); //disable TAP icon
        }
    }

    void ChangeUIicons() //changes a sprite if coin is collected 
    {
        RestartButton();

        if (LevelManager.StarCollected1 == 1)
        {
            smallStar1.GetComponent<Image>().sprite = GoldStar;
            bigStar1.GetComponent<Image>().sprite = GoldStar;
        }
        if (LevelManager.StarCollected2 == 1)
        {
            smallStar2.GetComponent<Image>().sprite = GoldStar;
            bigStar2.GetComponent<Image>().sprite = GoldStar;
        }
        if (LevelManager.StarCollected3 == 1)
        {
            smallStar3.GetComponent<Image>().sprite = GoldStar;
            bigStar3.GetComponent<Image>().sprite = GoldStar;
        }
    }

    public void RestartButton()
    {
        if (Active.GetComponent<PlayerControls>().isDead == true)
        {
            restartButton.SetActive(true);
            pauseButton.SetActive(false);
        }
        else
        {
            restartButton.SetActive(false);
        }
    }
}
