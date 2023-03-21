using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class speedUpgrade : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 80f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity  = Vector2.right * -speed * Time.deltaTime;
    }
}
