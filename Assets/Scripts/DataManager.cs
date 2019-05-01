using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager
{
    public static int Coins; //game coins
    public static int Level1Star1, Level1Star2, Level1Star3;

    public static void LoadData()
    {
        Level1Star1 = PlayerPrefs.GetInt("Level 1 Star 1");
        Level1Star2 = PlayerPrefs.GetInt("Level 1 Star 2");
        Level1Star3 = PlayerPrefs.GetInt("Level 1 Star 3");
    }
}
