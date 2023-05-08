using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutpostAnimLineRendererOffset : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    LineRenderer rend;

    void Start()
    {
        rend = GetComponent<LineRenderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_BaseMap", new Vector2(-offset, 0));
    }
}
