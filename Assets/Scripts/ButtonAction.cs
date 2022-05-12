using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    //public gameobject manager zodat die kan spreken met andere objecten
    public GameObject Manager;
    public void RestartButton()
    {
        //laad scene " . . . "
        SceneManager.LoadScene(0);
    }
}
