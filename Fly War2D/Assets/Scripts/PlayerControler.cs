using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float Vspeed;
    public float Force;
    private Rigidbody2D rb;
    public Transform shootPoint;
    public GameObject bullet;
    public float fireRate;
    private float nextTimeFireRate = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextTimeFireRate)
        {
            nextTimeFireRate = Time.time + 1 / fireRate;
            Shoot();
        }
    }
    private void FixedUpdate()
    {
        float verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * Time.deltaTime,verticalMove * Vspeed * Time.deltaTime);        
    }
    private void Shoot()
    {
        GameObject bulletIns = Instantiate(bullet,shootPoint.position,Quaternion.identity);
        bulletIns.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Force);
        Destroy(bulletIns,1.5f);
    }
}
