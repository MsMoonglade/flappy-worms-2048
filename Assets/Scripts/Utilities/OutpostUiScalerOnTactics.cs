using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OutpostUiScalerOnTactics : MonoBehaviour
{
    public Vector3 tacticsSize;
    private Vector3 normalSize;

    private void OnEnable()
    {
        EventManager.StartListening(Events.EnterTactics, OnEnterTactics);
        EventManager.StartListening(Events.ExitTactics, OnExitTactics);
    }

    private void OnDisable()
    {
        EventManager.StopListening(Events.EnterTactics, OnEnterTactics);
        EventManager.StopListening(Events.ExitTactics, OnExitTactics);
    }

    private void Awake()
    {
        normalSize = transform.GetComponent<RectTransform>().localScale;
    }

    private void OnEnterTactics(object sender)
    {
        transform.GetComponent<RectTransform>().DOScale(tacticsSize, 1);
    }

    private void OnExitTactics(object sender)
    {
        transform.GetComponent<RectTransform>().DOScale(normalSize, 1);
    }
}
