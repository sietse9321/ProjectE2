using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjects : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject MainCanvas;
    public GameObject BackGround;

    void Start()
    {   
        Instantiate(MainCamera);
        Instantiate(BackGround);
        Instantiate(MainCanvas);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
