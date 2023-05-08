using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SmoothEnablerDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        transform.localScale = Vector3.zero;
        SmoothEnable();
    }

    private void OnDisable()
    {
        transform.localScale = Vector3.zero;
    }

    public void SmoothEnable()
    {
        transform.localScale = Vector3.zero;

        transform.DOScale(new Vector3(1, 1, 1), 0.15f);
    }

    public void SmoothDisable()
    {
        transform.DOScale(Vector3.zero, 0.15f)
            .OnComplete(() => this.gameObject.SetActive(false));
    }
}