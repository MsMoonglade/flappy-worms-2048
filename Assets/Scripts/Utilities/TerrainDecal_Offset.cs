using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class TerrainDecal_Offset : MonoBehaviour
{
    private DecalProjector decal;

    private void Start()
    {
        decal = transform.GetComponent<DecalProjector>();

        decal.uvScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
    }
}
