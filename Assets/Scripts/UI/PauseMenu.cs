using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public SceneBoss parent;
    
    public GameObject pauseButton;
    public GameObject pauseMenuUI;

    public void Resume()
    {
        pauseButton.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseButton.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
