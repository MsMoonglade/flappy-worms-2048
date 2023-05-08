using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OutpostScalerOnTactics : MonoBehaviour
{
    public Vector3 tacticsSize;
    private Vector3 normalSize;

    private void OnEnable()
    {
        EventManager.StartListening(Events.EnterTactics, OnEnterTactics);
        EventManager.StartListening(Events.ExitTactics, OnExitTactics);

        if (GameManager.instance != null)
        {
            if (GameManager.instance.inStrategicView)
            {
                OnEnterTactics(null);
            }

            if (!GameManager.instance.inStrategicView)
            {
                OnExitTactics(null);
            }
        }

        else
        {
            if (normalSize != null)
                transform.localScale = normalSize;
        }
    }

    private void OnDisable()
    {
        EventManager.StopListening(Events.EnterTactics, OnEnterTactics);
        EventManager.StopListening(Events.ExitTactics, OnExitTactics);
    }

    private void Awake()
    {
        normalSize = transform.localScale;
    }

    private void OnEnterTactics(object sender)
    {
        transform.DOScale(tacticsSize, 1);
    }

    private void OnExitTactics(object sender)
    {
        transform.DOScale(normalSize, 1);
    }
}
