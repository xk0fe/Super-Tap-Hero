using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBoss : MonoBehaviour
{
    public static int ScreenTap; //to understand how many times user tapped a screen
    public static uint CoinCount; //uint to prevent negative coin score  (highest coin score is 4,294,967,295)
    public short LevelCoinCount;
    public static bool StarCollected1, StarCollected2, StarCollected3; //check if star is collected

    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        
    }

    public void RestartLevel()
    {
        ResetLevelVariables();
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
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
        StarCollected1 = false;
        StarCollected2 = false;
        StarCollected3 = false;
    }
}
