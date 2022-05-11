using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public float movmentspeed = 5f;
    float jumpforce = 2;
    public Rigidbody2D rb;
    bool jumping;

    bool canjump;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float xMovment = Input.GetAxis("Horizontal") * movmentspeed;
        rb.velocity = new Vector2(xMovment, rb.velocity.y);
        if (Input.GetKeyDown("space") && canjump == true)
        {
            jumping = true;
        }
        if (jumping == true)
        {
            rb.AddForce(new Vector2(0, jumpforce * 100));
            jumping = false;
        }
    }
    private void FixedUpdate()
    {
        if (jumping == true)
        {
            rb.AddForce(new Vector2(0, jumpforce * 100));
            jumping = false;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "test")
        {
            canjump = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "test")
        {
            canjump = false;
        }
    }
}
