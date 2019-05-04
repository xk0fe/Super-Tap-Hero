using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : GameBoss
{
    public static int ScreenTap; //to understand how many times user tapped a screen
    public static int CoinCount; //uint to prevent negative coin score  (highest coin score is 4,294,967,295)
    public static int LevelCoinCount;
    public static int StarCollected1, StarCollected2, StarCollected3; //check if star is collected
    static string currentScene;
    public bool playerIsDead;

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
        LevelCoinCount = 0;
        StarCollected1 = 0;
        StarCollected2 = 0;
        StarCollected3 = 0;
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", CoinCount);
        Social.ReportScore(PlayerPrefs.GetInt("Coins"), leaderboard, (bool success) =>
        {
            if (success) print("Leadeboard updated!");
            else print("Leaderboard was not updated for some reason");
        });

        if (currentScene == "Level1")
        {
            GetTheAchievement(achievement1);
            if (StarCollected1 == 1)
            {
                PlayerPrefs.SetInt("Level 1 Star 1", StarCollected1);
            }
            if (StarCollected2 == 1)
            {
                PlayerPrefs.SetInt("Level 1 Star 2", StarCollected2);
            }
            if (StarCollected3 == 1)
            {
                PlayerPrefs.SetInt("Level 1 Star 3", StarCollected3);
            }
            
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
