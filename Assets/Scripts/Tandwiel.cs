using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tandwiel : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float Speed = 20f;
    private float Time = 2f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rigidbody.velocity = transform.right * Speed;
        Destroy(gameObject, Time);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("L");
        }
    }
}
