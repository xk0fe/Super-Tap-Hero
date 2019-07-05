using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStarController : MonoBehaviour
{
    private string levelName = "L";
    [Header("Images")]
    public Sprite SilverStar;
    public Sprite GoldStar;
    [Header("Star objects")]
    public GameObject lvl1Star1;
    public GameObject lvl1Star2;
    public GameObject lvl1Star3;

    void Update()
    {
        ChangeLevelStars();
    }

    public void ChangeLevelStars()
    {
        if (PlayerPrefs.GetInt((levelName + "S1"))  == 1)
        {
            lvl1Star1.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star1.GetComponent<Image>().sprite = SilverStar;
        }

        if (PlayerPrefs.GetInt((levelName + "S2")) == 1)
        {
            lvl1Star2.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star2.GetComponent<Image>().sprite = SilverStar;
        }

        if (PlayerPrefs.GetInt((levelName + "S3")) == 1)
        {
            lvl1Star3.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star3.GetComponent<Image>().sprite = SilverStar;
        }
    }

}
