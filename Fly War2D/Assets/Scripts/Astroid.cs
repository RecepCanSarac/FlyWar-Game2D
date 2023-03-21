using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Force;
    private float random;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        random = UnityEngine.Random.Range(-100,101);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-Force * Time.deltaTime,random * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
        }
    }
}
