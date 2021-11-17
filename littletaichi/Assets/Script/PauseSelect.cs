using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseSelect : MonoBehaviour
{
    Button Restart;
    Button Title ;
    Button Exit ;

    void Start()
    {
        Restart = GameObject.Find("/Menu/PausePanel/Restart").GetComponent<Button>();
        Title = GameObject.Find("/Menu/PausePanel/Title").GetComponent<Button>();
        Exit = GameObject.Find("/Menu/PausePanel/Exit").GetComponent<Button>();

        Restart.Select();
    }
}