using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCharacterSwitch : MonoBehaviour
{
    public static string activeCharacter = PlayerPrefs.GetString("ActiveCharacter");

    public GameObject Gameboy;
    public GameObject Alien;

    void Switcher()
    {
        if(activeCharacter == "Gameboy")
        {
            Gameboy.SetActive(true);
            Alien.SetActive(false);
        }
        if (activeCharacter == "Alien")
        {
            Gameboy.SetActive(false);
            Alien.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Switcher();
    }
}
