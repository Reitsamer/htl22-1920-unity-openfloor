using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 100f;

    private Material material;

    private Color[] colors =
    {
        Color.blue,
        Color.green,
        Color.magenta,
        Color.red,
        Color.yellow,
    };

    private int colorIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            colorIndex = colorIndex + 1;
            if (colorIndex >= colors.Length)
                colorIndex = 0;
            
            material.color = colors[colorIndex];
        }

        transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }
}
