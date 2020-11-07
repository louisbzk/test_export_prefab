using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScrolling : MonoBehaviour
{
    public float xScrollSpeed = 0.01f;
    public float yScrollSpeed = 1f;
    
    Renderer renderer;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset = new Vector2(xScrollSpeed, yScrollSpeed)*Time.time;
    }
}