using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public Text timeText;
    public Text nameText;
    public Text partyNameText;
    private void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("UserName");
        partyNameText.text = PlayerPrefs.GetString("UserName");
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
        
    }
}
