using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class UI : MonoBehaviour
{
    public GameObject RepeatButton;
    public GameObject TapButton;
    

    void Update()
    {

        if (PlayerControls.ScreenTap == 0) //show TAP icon if player has not tapped
        {
            RepeatButton.SetActive(false);
            TapButton.SetActive(true);
        }
        else //hide TAP icon if player has tapped
        {
            RepeatButton.SetActive(true);
            TapButton.SetActive(false);
        }
    }

    public void RepeatButtonFunc()
    {
        ResetLevelVariables();
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void ResetLevelVariables()
    {
        PlayerControls.ScreenTap = 0;
        PlayerControls.CoinCollected1 = false;
        PlayerControls.CoinCollected2 = false;
        PlayerControls.CoinCollected3 = false;
    }
}
