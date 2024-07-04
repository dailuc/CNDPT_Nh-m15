using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject btnGameRestart;
    public static UIManager instance;

    private void Awake()
    {
        UIManager.instance = this;
        btnGameRestart = GameObject.Find("BtnGameRestart");
        btnGameRestart.SetActive(false);
    }
}
