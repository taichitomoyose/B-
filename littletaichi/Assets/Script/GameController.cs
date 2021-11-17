//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//public class GameController : MonoBehaviour
//{
//    public Text countText;
//    private Rigidbody rb;
//    private int count;
//    public Text gameclearText;
//    //float ctime = 0;
//    private Text cleartext;
//    public GameObject panel;
//     GameObject panel2;
//    public Text timerText;
//    int fr = 0;

//    //private int taichi = 0;

//    public static int clearflg = 0;

//    void Start()
//    {
//        cleartext = GameObject.Find("Time").GetComponent<Text>();
//        //cleartext = gameObject.SetActive(false);
//        rb = GetComponent<Rigidbody>();
//        count = 0; // 初期化
//        SetCountText();
//        gameclearText.text = "";
//        //cleartext = GameObject.Find("cleartext");
//        panel = GameObject.Find("ResultPanel");
//        panel.SetActive(false);
//        panel2 = GameObject.Find("RetryPanel");
//        panel2.SetActive(false);
//    }
//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.CompareTag("Item"))
//        {
//            other.gameObject.SetActive(false);
//            count = count + 1;
//            SetCountText();
//        }
//    }
//    void SetCountText()
//    {
//        countText.text = count.ToString() + " / 12 ";
//        if (count >= 12)
//        {
//            fr += 1;
//            gameclearText.text = "GAME CLEAR"; // 全部のアイテムを取得したら（１２個配置していた場合）
//            //if (fr >= 61)
//            //{
//            //    clearflg = 1;
//            //    panel.gameObject.SetActive(true);
//            //    Time.timeScale = 0f;
//            //}
//        }
//    }

//    void Update()
//    {
//        //countText.text = count.ToString() + " / 12 ";
//        if (count >= 12)
//        {
//            fr += 1;
//            //gameclearText.text = "GAME CLEAR"; // 全部のアイテムを取得したら（１２個配置していた場合）
//            if (fr >= 61)
//            {
//                clearflg = 1;
//                timerText.enabled = false;
//                panel.gameObject.SetActive(true);
//                Time.timeScale = 0f;
//                if (Input.GetKey("joystick button 1"))
//                {
//                    Debug.Log("button1");
//                    panel.gameObject.SetActive(false);
//                    panel2.gameObject.SetActive(true);
//                }
//            }
//        } 
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public GameObject particleObject;
    public Text CrearText;
    public Text countText;
    private Rigidbody rb;
    private int count;
    //public Text gameclearText;
    float ctime = 0;
    private Text cleartext;
    private GameObject panel;
    private GameObject panel2;

    private int taichi = 0;

    public static int clearflg = 0;

    int flag = 0;
    void Start()
    {
        //cleartext = GameObject.Find("Time").GetComponent<Text>();
        //cleartext = gameObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
        count = 0; // 初期化
        SetCountText();
        //gameclearText.text = "";
        //cleartext = GameObject.Find("cleartext");
        panel = GameObject.Find("ResultPanel");
        panel.gameObject.SetActive(false);
        panel2 = GameObject.Find("RetryPanel");
        panel2.gameObject.SetActive(false);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = count.ToString() + " / 12 ";
        if (count >= 1)
        {
            CrearText.text = "GAME CLEAR";
            Time.timeScale = 0f;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            //gameclearText.text = ""; // 全部のアイテムを取得したら（１２個配置していた場合）
            //if (Input.GetKey("joystick button 1") && flag == 0)
            //{
            //    flag = 1;
            //    clearflg = 1;
            //    panel.gameObject.SetActive(true);
            //    CrearText.enabled = false;
            //    Debug.Log("CLEAR");
            //}
        }

    }

    public void Update()
    {
        if (Input.GetButtonDown("B Button") && flag == 0)
        {
            flag = 1;
            clearflg = 1;
            panel.gameObject.SetActive(true);
            CrearText.enabled = false;
            Debug.Log("CLEAR");
        }

        else if (Input.GetButtonDown("B Button")&& flag == 1)
        {
            Debug.Log("button1");
            panel.gameObject.SetActive(false); //リザルト
            panel2.gameObject.SetActive(true); //リトライ
            Debug.Log("RESULT");
        }
    }
}