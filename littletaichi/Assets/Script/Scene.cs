using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey("joystick button 0"))
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("button0");
        }
    }
}