using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    public bool btnLvl1, btnLvl2, btnLvl3;
    public GameObject PlayButton;
    
    void Update()
    {
        if(btnLvl1 == true)
        {
            PlayButton.SetActive(true);
        }
        if (btnLvl2 == true)
        {
            PlayButton.SetActive(true);
        }
        if (btnLvl3 == true)
        {
            PlayButton.SetActive(true);
        }
    }

    public void PlayLevel()
    {
        if (btnLvl1 == true)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
        if (btnLvl2 == true)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        if (btnLvl3 == true)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }

    public void Level1()
    {   
        btnLvl2 = false;
        btnLvl3 = false;
        btnLvl1 = true;
    }

    public void Level2()
    {
        btnLvl1 = false;
        btnLvl3 = false;
        btnLvl2 = true;
    }

    public void Level3()
    {
        btnLvl1 = false;
        btnLvl2 = false;
        btnLvl3 = true;
    }
}
