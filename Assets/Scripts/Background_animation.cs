using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_animation : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    public float speed = 1f;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        _meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
