using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCharacterSwitch : MonoBehaviour
{
    public static string activeCharacter;

    public GameObject Gameboy;
    public GameObject Alien;
    public GameObject Emily;
    public GameObject Active;

    private void Start()
    {
        activeCharacter = PlayerPrefs.GetString("ActiveCharacter");
        Switcher();
    }

    public void Switcher()
    {
        if(activeCharacter == "Gameboy")
        {
            Active = Gameboy;
            Gameboy.SetActive(true);
            Alien.SetActive(false);
            Emily.SetActive(false);
        }
        if (activeCharacter == "Alien")
        {
            Active = Alien;
            Gameboy.SetActive(false);
            Alien.SetActive(true);
            Emily.SetActive(false);
        }
        if (activeCharacter == "Emily")
        {
            Active = Emily;
            Gameboy.SetActive(false);
            Alien.SetActive(false);
            Emily.SetActive(true);
        }
    }
}
