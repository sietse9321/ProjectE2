using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjects : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject backGround;
    public GameObject mainCamera;
    public GameObject manager;
    void Start()
    {
        Instantiate(backGround);
        Instantiate(mainCanvas);
        Instantiate(mainCamera);
        Instantiate(manager);
    }
}
