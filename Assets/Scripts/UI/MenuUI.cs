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

    public int L1S1, L1S2, L1S3;

    void Update()
    {
        AllCoinCountText.text = SceneBoss.CoinCount.ToString();
        TEST();
        ChangeLevelStars();
    }

    void TEST()
    {
        L1S1 = PlayerPrefs.GetInt("Level 1 Star 1");
        L1S2 = PlayerPrefs.GetInt("Level 1 Star 2");
        L1S3 = PlayerPrefs.GetInt("Level 1 Star 3");
    }

    void ChangeLevelStars()
    {
        if (L1S1 == 1)
        {
            lvl1Star1.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star1.GetComponent<Image>().sprite = SilverStar;
        }

        if (L1S2 == 1)
        {
            lvl1Star2.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star2.GetComponent<Image>().sprite = SilverStar;
        }

        if (L1S3 == 1)
        {
            lvl1Star3.GetComponent<Image>().sprite = GoldStar;
        }
        else
        {
            lvl1Star3.GetComponent<Image>().sprite = SilverStar;
        }
    }

}
