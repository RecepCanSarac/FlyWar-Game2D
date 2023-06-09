using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float Espeed;
    private Rigidbody2D rb;
    public Transform shootPoint,Target;
    public GameObject Ebullet;
    public float Force;
    public float fireRate;
    private float nextTimeFireRate = 0;
    public static int enemyHealth; 

    public float Distance;
    void Start()
    {
        enemyHealth = 20;
        Physics2D.queriesStartInColliders = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D trigger = Physics2D.Raycast(transform.position,-transform.right,Distance);
        if (trigger.collider == null)
        {
            Debug.DrawLine(transform.position, trigger.point, Color.yellow);
        }
        else if(trigger.collider.CompareTag("Player"))
        {
            Debug.DrawLine(transform.position,trigger.point,Color.red);
            if (Time.time > nextTimeFireRate)
            {
                nextTimeFireRate = Time.time + 1 / fireRate;
                Shoot();
            }
        }
        else if (trigger.collider != null)
        {
            Debug.DrawLine(transform.position, trigger.point, Color.green);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-Espeed * Time.deltaTime,rb.velocity.y);
    }

    private void Shoot()
    {
        GameObject bulletIns = Instantiate(Ebullet, shootPoint.position, Quaternion.identity);
        bulletIns.GetComponent<Rigidbody2D>().AddForce(Vector2.right * -Force);
        Destroy(bulletIns, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DestroyWall"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("bullet"))
        {
            enemyHealth -= 12;
            if (enemyHealth <= 0)
            {
                if (EventManager.enemyDead != null)
                {
                    EventManager.enemyDead();
                    Destroy(this.gameObject);
                }
            }
            Destroy(collision.gameObject);
        }
    }
}
