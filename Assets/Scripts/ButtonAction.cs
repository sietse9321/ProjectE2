using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public GameObject Manager;
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
