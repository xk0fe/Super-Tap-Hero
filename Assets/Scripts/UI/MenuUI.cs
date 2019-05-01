
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public SceneBoss parent;
    public Text AllCoinCountText;
    [Header("Images")]
    public Sprite SilverStar;
    public Sprite GoldStar;
    [Header("1 level")]
    public GameObject lvl1Star1;
    public GameObject lvl1Star2;
    public GameObject lvl1Star3;

    void Update()
    {
        AllCoinCountText.text = SceneBoss.CoinCount.ToString();
        DataManager.LoadData();
        ChangeLevelStars();
    }

    void ChangeLevelStars()
    {
        if (DataManager.Level1Star1 == 1)
        {
            lvl1Star1.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star1.GetComponent<Image>().sprite = SilverStar;
        }

        if (DataManager.Level1Star2 == 1)
        {
            lvl1Star2.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star2.GetComponent<Image>().sprite = SilverStar;
        }

        if (DataManager.Level1Star3 == 1)
        {
            lvl1Star3.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star3.GetComponent<Image>().sprite = SilverStar;
        }
    }

}
