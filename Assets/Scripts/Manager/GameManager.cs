using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameStatus gameStatus;

    [HideInInspector]
    public bool inStrategicView;

    private int currentLevel;

    public int CurrentLevel
    {
        get
        {
            return currentLevel;
        }

        set
        {
            currentLevel = value;
            PlayerPrefs.SetInt("CurrentLevel", CurrentLevel);
        }
    }

    private void Awake()
    {
        instance = this;

        gameStatus = GameStatus.InStartGame;
    }

    private void Start()
    {
        //currentLevel set
        if (PlayerPrefs.HasKey("CurrentLevel"))
            CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");
        else
        {
            CurrentLevel = 1;
        }

        inStrategicView = false;

        StartGame();
    }

    public void StartGame()
    {
        gameStatus = GameStatus.InGame;
        EventManager.TriggerEvent(Events.startPlay);

        UiManager.instance.EnableGameUi();
    }

    public void EndGame()
    {
        gameStatus = GameStatus.InUi;
        EventManager.TriggerEvent(Events.endGame);

        CurrentLevel = CurrentLevel+1;

        UiManager.instance.EnableEndGameUi();
    }

    public void OnCharacterDie()
    {
        gameStatus = GameStatus.InUi;
        EventManager.TriggerEvent(Events.die);

        UiManager.instance.EnableRetryUi();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(2);
    }

    public bool InGame()
    {
        if (gameStatus == GameStatus.InGame )
            return true;

        else
            return false;
    }

    public bool InStartGame()
    {
        if (gameStatus == GameStatus.InStartGame)
            return true;

        else
            return false;
    }

    public bool InUI()
    {
        if (gameStatus == GameStatus.InUi)
            return true;

        else
            return false;
    }
}

public enum GameStatus
{
    InGame,
    InStartGame,
    InUi,
}