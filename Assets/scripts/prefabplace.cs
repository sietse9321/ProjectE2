using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabplace : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Level;
    public GameObject Player;

    private void Start()
    {
        Instantiate(MainCamera);
        Instantiate(Level);
        Instantiate(Player);
    }
}
