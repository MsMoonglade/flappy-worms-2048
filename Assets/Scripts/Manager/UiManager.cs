using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MoreMountains.Tools;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    [Header("GeneralPanel")]
    public GameObject mainMenuUi;
    public GameObject gameUi;
    public GameObject endGameUi;
    public GameObject retryUi;

    private void Awake()
    {
        instance = this;
    }

    public void EnableGameUi()
    {
        endGameUi.SetActive(false);
        mainMenuUi.SetActive(false);
        retryUi.SetActive(false);
        gameUi.SetActive(true);
    }

    public void EnableEndGameUi()
    {
        mainMenuUi.SetActive(false);
        gameUi.SetActive(false);
        retryUi.SetActive(false);
        endGameUi.SetActive(true);
    }

    public void EnableRetryUi()
    {        
        mainMenuUi.SetActive(false);
        gameUi.SetActive(false);
        endGameUi.SetActive(false);
        retryUi.SetActive(true);
    }

    public void DisableAllUi()
    {
        mainMenuUi.SetActive(false);
        endGameUi.SetActive(false);
        gameUi.SetActive(false);
        retryUi.SetActive(false);
    }
}