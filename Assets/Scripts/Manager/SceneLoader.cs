using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public bool force;
    public int levelToForce;

    private int actualLevel;

    private void Awake()
    {
        if (!force)
        {
            if (PlayerPrefs.HasKey("CurrentLevel"))
                actualLevel = PlayerPrefs.GetInt("CurrentLevel");
            else
            {
                actualLevel = 1;
                PlayerPrefs.SetInt("CurrentLevel", actualLevel);
            }

            if (actualLevel < SceneManager.sceneCountInBuildSettings)
                SceneManager.LoadScene(actualLevel);
            else
                SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCountInBuildSettings));
        }

        else
        {
            SceneManager.LoadScene(levelToForce);
        }
    }
}