using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialDesing : MonoBehaviour
{
    [SerializeField, Range(-.2f, 1f)] float speed;
    Renderer tex;
    void Start()
    {
        tex = GetComponent<Renderer>();
    }

    void Update()
    {
        tex.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
