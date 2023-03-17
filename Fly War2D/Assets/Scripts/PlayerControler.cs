using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float Vspeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        float verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * Time.deltaTime,verticalMove * Vspeed * Time.deltaTime);

        
    }

}
