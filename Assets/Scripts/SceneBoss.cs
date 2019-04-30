using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBoss : GameBoss
{
    public static int ScreenTap; //to understand how many times user tapped a screen
    public static int CoinCount; //uint to prevent negative coin score  (highest coin score is 4,294,967,295)
    public int LevelCoinCount;
    public static int StarCollected1, StarCollected2, StarCollected3; //check if star is collected
    string currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        CoinCount = PlayerPrefs.GetInt("Coins");
    }

    public void AddCoinsOnCompletion() //adding level coins to game coins on level complete
    {
        CoinCount += LevelCoinCount;
        SaveData();
    }

    public void RestartLevel()
    {
        ResetLevelVariables();
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void GoToMenu()
    {
        ResetLevelVariables();
        SceneManager.LoadScene("MainScreen", LoadSceneMode.Single);
    }

    public void ResetLevelVariables()
    {
        Time.timeScale = 1f;
        ScreenTap = 0;
        StarCollected1 = 0;
        StarCollected2 = 0;
        StarCollected3 = 0;
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", CoinCount);

        if (currentScene == "Level1")
        {
            PlayerPrefs.SetInt("Level 1 Star 1", StarCollected1);
            PlayerPrefs.SetInt("Level 1 Star 2", StarCollected2);
            PlayerPrefs.SetInt("Level 1 Star 3", StarCollected3);
            Debug.Log("Data stored!");
        }
        else
        {
            Debug.Log("in development");
        }
    }

    public void ResetSavedData()
    {
        PlayerPrefs.DeleteAll();
    }
}
