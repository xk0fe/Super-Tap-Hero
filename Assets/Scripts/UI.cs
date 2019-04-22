using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class UI : MonoBehaviour
{
    public GameObject RepeatButton;
    public GameObject TapButton;

    public int ScreenTap;

    public PlayerControls parent; //linking PlayerControls.cs - setup

    void Update()
    {
        ScreenTap = parent.ScreenTap; //linking process

        if (ScreenTap == 0)
        {
            RepeatButton.SetActive(false);
            TapButton.SetActive(true);
        }
        else
        {
            RepeatButton.SetActive(true);
            TapButton.SetActive(false);
        }
    }

    public void RepeatButtonFunc()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
