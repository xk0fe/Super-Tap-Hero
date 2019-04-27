using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public SceneBoss parent;
    public GameObject LevelCompleteUI;
    public GameObject LevelCoinCount; //top hud element
    public GameObject LevelStarCount; //top hud element
    public GameObject PauseButton;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            parent.AddCoinsOnCompletion();
            Time.timeScale = 0f;
            LevelCompleteUI.SetActive(true);
            LevelCoinCount.SetActive(false);
            LevelStarCount.SetActive(false);
            PauseButton.SetActive(false);
        }
    }
}
