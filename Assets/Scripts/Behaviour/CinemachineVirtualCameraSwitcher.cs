using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineVirtualCameraSwitcher : MonoBehaviour
{
    public static CinemachineVirtualCameraSwitcher instance;

    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera strategicCamera;

    private void Awake()
    {
        instance = this;
    }

    public void SwitchToPlayerCamera()
    {
        playerCamera.Priority = 11;
        strategicCamera.Priority = 0;
    }

    public void SwitchToStrategicCamera()
    {
        strategicCamera.Priority = 11;
        playerCamera.Priority = 0;
    }
}