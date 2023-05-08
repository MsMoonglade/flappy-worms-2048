using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public Camera mainCamera;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        //IF ON MOBILE
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            if (GameManager.instance.InGame() && !GameManager.instance.inStrategicView)
            {                   
                SwipeMovingMobile();
            }
        }

        //IF IN EDITOR
        else
        {
            if (GameManager.instance.InGame() && !GameManager.instance.inStrategicView)
            {
                SwipeMovingEditor();
            }
        }
    }

    private void SwipeMovingEditor()
    {
 
    }

    private void SwipeMovingMobile()
    {
      
    }
}