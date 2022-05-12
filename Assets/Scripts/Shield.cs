using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shield;
    public GameObject shieldSpawn;
    public GameObject coin;
    public GameObject canvas;
    float timer = 0;
    float maxTime = 5;
    public int shieldHp = 2;
    bool shieldCheck = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            canvas.SetActive(false);
        }
        if (shieldCheck == true)
        {
            if (Input.GetKeyDown("q"))
            {
                Instantiate(shield, shieldSpawn.transform.position, shieldSpawn.transform.rotation);
                shieldCheck = false;
            }
        }
        if (shieldHp == 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Shield"));
        }
        timer += Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShieldPickUp")
        {
            shieldCheck = true;
            coin.SetActive(false);
            canvas.SetActive(true);
            shieldHp = 2;
            timer = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Shield")
        {
            print("ok");
            shieldHp--;
        }
    }
}
