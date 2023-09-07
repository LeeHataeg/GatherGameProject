using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public GameObject StateBox;

    public void ListOfAttendant()
    {
        StateBox.SetActive(true);
    }
    public void ListClose()
    {
        StateBox.SetActive(false);
    }
}
