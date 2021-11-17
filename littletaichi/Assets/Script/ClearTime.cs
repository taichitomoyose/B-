using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour
{
    float ctime = 0;
    int cflg = 0;
    GameObject cleartext;
    GameObject timetext;

    // Start is called before the first frame update
    void Start()
    {
        cleartext = GameObject.Find("Time");
        cleartext.gameObject.SetActive(false);
        //timetext = GameObject.Find("jikantext");
        //timetext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cflg = GameController.clearflg;
        ctime += Time.deltaTime;
        cleartext.GetComponent<Text>().text = ctime.ToString("F2");
        if (cflg == 1)
        {
            cleartext.gameObject.SetActive(true);
            //timetext.gameObject.SetActive(true);
        }

    }
}
