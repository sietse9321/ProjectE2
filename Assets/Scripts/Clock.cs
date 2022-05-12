using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    float timer = 0;
    float maxTime = 2f;
    public GameObject tandwiel;
    public GameObject clock2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            Instantiate(tandwiel, clock2.transform.position, clock2.transform.rotation);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("L");
        }
    }
}
