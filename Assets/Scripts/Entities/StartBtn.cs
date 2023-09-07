using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public TextMeshProUGUI playerInputName;
    private string playerName = null;

    public void GoGather()
    {
        playerName = playerInputName.text.ToString();
        PlayerPrefs.SetString("UserName", playerName);
        SceneManager.LoadScene("MainScene");
    }
}