using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackBtn : MonoBehaviour
{
    public GameObject currentBox;
    public GameObject UIBox;
    public GameObject SelectBox;

    public void GoBack()
    {
        currentBox.SetActive(false);
        UIBox.SetActive(false);
        SelectBox.SetActive(true);
        PlayerPrefs.SetString("UserCharacter", null);
    }
}
