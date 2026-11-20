using System.Numerics;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    public float ScrollSpeed;
    public MeshRenderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new UnityEngine.Vector2(ScrollSpeed * Time.deltaTime,0);
    }
}
