using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCharacterSwitch : MonoBehaviour
{
    public string activeCharacter = "Gameboy"; //current ACTIVE character
    public string selectedCharacter = "Gameboy"; //cyrrebkt VIEWING character
    [Header("Game objects")]
    public GameObject CurrentCharacter; //selected character image
    public GameObject gbGameboy;
    public GameObject gbAlien;
    [Header("Images")]
    public Text SelectedCharacterName;
    public Sprite sGameboy;
    public Sprite sAlien;

    public void btnGameboy()
    {
        CurrentCharacter.GetComponent<Image>().sprite = sGameboy;
        activeCharacter = selectedCharacter = "Gameboy";
    }

    public void btnAlien()
    {
        CurrentCharacter.GetComponent<Image>().sprite = sAlien;
        activeCharacter = selectedCharacter  = "Alien";
    }

    public void Update()
    {
        SelectedCharacterName.text = selectedCharacter.ToString();
        LateUpdate();
    }

    public void LateUpdate()
    {
        PlayerPrefs.SetString("ActiveCharacter", activeCharacter);
    }
}
