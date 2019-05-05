using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCharacterSwitch : MonoBehaviour
{
    public string activeCharacter = "Gameboy"; //current ACTIVE character
    public string selectedCharacter = "Gameboy"; //cyrrebkt VIEWING character
    [Header("Game objects")]
    public RectTransform rt;
    public GameObject CurrentCharacter; //selected character image
    public GameObject btnSelect;
    public GameObject btnSelected;
    [Header("Images")]
    public Text SelectedCharacterName;
    public Sprite sGameboy;
    public Sprite sAlien;
    public Sprite sEmily;

    public void btnGameboy()
    {
        CurrentCharacter.GetComponent<Image>().sprite = sGameboy;
        selectedCharacter = "Gameboy";
    }

    public void btnAlien()
    {
        CurrentCharacter.GetComponent<Image>().sprite = sAlien;
        selectedCharacter  = "Alien";
    }

    public void btnEmily()
    {
        CurrentCharacter.GetComponent<Image>().sprite = sEmily;
        selectedCharacter = "Emily";
    }

    public void btnStatusCheck()
    {
        if (activeCharacter == "Gameboy" & CurrentCharacter.GetComponent<Image>().sprite == sGameboy)
        {
            btnSelect.SetActive(false);
            btnSelected.SetActive(true);
        }
        else if(activeCharacter == "Alien" & CurrentCharacter.GetComponent<Image>().sprite == sAlien)
        {
            btnSelect.SetActive(false);
            btnSelected.SetActive(true);
        }
        else if(activeCharacter == "Emily" & CurrentCharacter.GetComponent<Image>().sprite == sEmily)
        {
            btnSelect.SetActive(false);
            btnSelected.SetActive(true);
        }
        else
        {
            btnSelect.SetActive(true);
            btnSelected.SetActive(false);
        }
    }

    public void btnSelectFunc()
    {
        activeCharacter = selectedCharacter;
        PlayerPrefs.SetString("ActiveCharacter", activeCharacter);
    }

    public void Update()
    {
        PlayerPrefs.SetString("ActiveCharacter", activeCharacter);
        activeCharacter = PlayerPrefs.GetString("ActiveCharacter");
        SelectedCharacterName.text = selectedCharacter.ToString();
        btnStatusCheck();
    }
 
}
