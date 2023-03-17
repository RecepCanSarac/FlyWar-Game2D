using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacgroundScripts : MonoBehaviour
{
    private MeshRenderer meshRender;
    private Material material;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        material = meshRender.material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offsetM = material.mainTextureOffset;
        offsetM.x = transform.position.x / transform.localScale.x;
        material.mainTextureOffset = offsetM;
    }
}
