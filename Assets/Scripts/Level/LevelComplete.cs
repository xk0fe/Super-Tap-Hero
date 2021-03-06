﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField]
    private LevelManager levelManager;

    public GameObject LevelCompleteUI; //Level Comple Window
    public GameObject LevelCoinCount; //top hud element
    public GameObject LevelStarCount; //top hud element
    public GameObject pauseButton;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelManager.AddCoinsOnCompletion(); //LevelComplete : LevelUI : SceneBoss
            Time.timeScale = 0f;
            pauseButton.SetActive(false);
            LevelCompleteUI.SetActive(true);
            LevelCoinCount.SetActive(false);
            LevelStarCount.SetActive(false);
        }
    }
}
