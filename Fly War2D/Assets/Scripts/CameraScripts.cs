using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScripts : MonoBehaviour
{
    public Transform Target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.position.x > transform.position.x - 7.5f)
        {
            transform.position = new Vector3(Target.position.x + 7.5f,transform.position.y,transform.position.z);
        }
    }
}
