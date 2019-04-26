using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeusEx : MonoBehaviour
{
    public static int ScreenTap; //to understand how many times user tapped a screen
    public static uint CoinCount; //uint to prevent negative coin score  (highest coin score is 4,294,967,295)
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

    public void RepeatButtonFunc()
    {
        ResetLevelVariables();
        //SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void ResetLevelVariables()
    {
        ScreenTap = 0;
        StarCollected1 = false;
        StarCollected2 = false;
        StarCollected3 = false;
    }
}
