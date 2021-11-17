using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    int startflag = 0;


    Button Restart;
    void Start()
    {
        Restart = GameObject.Find("Menu/PausePanel/Restart").GetComponent<Button>();
        pausePanel.SetActive(false);
        //pauseButton.onClick.AddListener(Pause);
        //resumeButton.onClick.AddListener(Resume);
    }

    void Update()
    {
        bool start = Input.GetButtonDown("Pause");
        //bool start = Input.GetKeyDown(KeyCode.V);
        if (start == true && startflag == 0)
        {

            Time.timeScale = 0f;//時間停止
            pausePanel.SetActive(true);
            Restart.Select();

            Debug.Log("START");
            startflag = 1;

            Debug.Log(startflag);
        }

        else if (start == true && startflag == 1)
        {
            Time.timeScale = 1f;//戻る
            pausePanel.SetActive(false);

            startflag = 0;

        }
        //Debug.Log(startflag);

    }

    //        Time.timeScale = 1;//再開
    //        pausePanel.SetActive(false);
}