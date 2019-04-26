using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarScore : MonoBehaviour
{
    public Sprite SilverStar; //if coin is NOT collected
    public Sprite GoldStar; //if coin is collected
    [Header("UI elements")]
    public GameObject smallStar1; 
    public GameObject smallStar2;
    public GameObject smallStar3; 
    public GameObject bigStar1;
    public GameObject bigStar2;
    public GameObject bigStar3;

    void Update()
    {
        ChangeUIicons();
    }

    void ChangeUIicons() //changes a sprite if coin is collected 
    {
        if (DeusEx.StarCollected1 == true)
        {
            smallStar1.GetComponent<Image>().sprite = GoldStar;
            bigStar1.GetComponent<Image>().sprite = GoldStar;
        }
        if (DeusEx.StarCollected2 == true)
        {
            smallStar2.GetComponent<Image>().sprite = GoldStar;
            bigStar2.GetComponent<Image>().sprite = GoldStar;
        }
        if (DeusEx.StarCollected3 == true)
        {
            smallStar3.GetComponent<Image>().sprite = GoldStar;
            bigStar3.GetComponent<Image>().sprite = GoldStar;
        }
    }
}
