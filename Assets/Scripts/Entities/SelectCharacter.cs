using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public GameObject selectionBox;
    public GameObject canvasBox;
    public GameObject penguinBox;
    public GameObject wizardBox;
    public void SelectP()
    {
        selectionBox.SetActive(false);
        canvasBox.SetActive(true);
        penguinBox.SetActive(true);
        PlayerPrefs.SetString("UserCharacter", "Penguin");
    }
    public void SelectW()
    {
        selectionBox.SetActive(false);
        canvasBox.SetActive(true);
        wizardBox.SetActive(true);
        PlayerPrefs.SetString("UserCharacter", "Wizard");
    }
}
