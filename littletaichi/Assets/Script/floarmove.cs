using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floarmove : MonoBehaviour
{

    float speed = 1f;//adRotateの速度調節
    float respeed = 1f;//reRotateの速度調節
    public float adRotate = 0;//速度
    public float reRotate = 0;//戻る速度
    float zRotate = 0;//Zの角度
    float xRotate = 0;//Xの角度
    Transform a;//意味ない
    float px, pz;//よくわからん

    // Use this for initialization
    void Start()
    {
        a = GetComponent<Transform>();//意味無し
    }

    // Update is called once per frame
    void Update()
    {
        px = a.localEulerAngles.x;//よくわからん
        pz = a.localEulerAngles.z;//よくわからん
        float z = Input.GetAxis("Horizontal");//横
        float x = Input.GetAxis("Vertical");//奥
        //Debug.Log(reRotate);//スピード観測

        if (x == 1)//奥に傾けたら
        {
            reRotate = 0;//戻す速度を０に戻す
            adRotate = Mathf.Clamp(adRotate + speed, 0, 90);//速度制限
            xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);//傾き制限(範囲、最小、最大）
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//角度制限しながら進む(x、y,z);
            //Debug.Log(adRotate);
        }
        if (x == -1)//手前に傾けたら
        {
            reRotate = 0;//戻す速度を０に戻す
            adRotate = Mathf.Clamp(adRotate + speed, 0, 90);//速度制限
            xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);//傾き制限(範囲、最小、最大）
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//角度制限しながら進む(x、y,z);
        }
        if (z == 1)//右に傾けたら
        {
            reRotate = 0;//戻す速度を０に戻す
            adRotate = Mathf.Clamp(adRotate + speed, 0, 90);//速度制限
            zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);//傾き制限(範囲、最小、最大）
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//角度制限しながら進む(x、y,z);
        }
        if (z == -1)//左に傾けたら
        {
            reRotate = 0;//戻す速度を０に戻す
            adRotate = Mathf.Clamp(adRotate + speed, 0, 90);//速度制限
            zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);//傾き制限(範囲、最小、最大）
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//角度制限しながら進む(x、y,z);
        }

        //戻るコード

        if (x == 0 && z == 0)//入力されていなかったら
        {
            adRotate = Mathf.Clamp(adRotate - respeed, 0, 90);
            if (adRotate == 0)
            {
                if (zRotate <= 0)//左の傾きが0以下だったら
                {
                    //adRotate = 0;//傾ける速度を０に戻す
                    reRotate = Mathf.Clamp(reRotate + respeed, 0, 90);//速度制限
                    zRotate += Time.deltaTime * reRotate;//戻る速度
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//戻るコード
                }
                if (zRotate >= 0) //右の傾きが0以上だったら
                {
                    //adRotate = 0;//傾ける速度を０に戻す
                    reRotate = Mathf.Clamp(reRotate + respeed, 0, 90);//速度制限
                    zRotate -= Time.deltaTime * reRotate;//戻る速度
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//戻るコード
                }
                if (xRotate <= 0)//手前の傾きが0以下だったら
                {
                    //adRotate = 0;//傾ける速度を０に戻す
                    reRotate = Mathf.Clamp(reRotate + respeed, 0, 90);//速度制限
                    xRotate += Time.deltaTime * reRotate;//戻る速度
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//戻るコード
                }
                if (xRotate >= 0)//奥の傾きが0以上だったら
                {
                    //adRotate = 0;//傾ける速度を０に戻す
                    reRotate = Mathf.Clamp(reRotate + respeed, 0, 90);//速度制限
                    xRotate -= Time.deltaTime * reRotate;//戻る速度
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);//戻るコード
                }
            }
        }

        //if (xRotate <=0&&zRotate<=0 )//戻る速度を０にするのを書きたい
        //{
        //    reRotate = 0;
        //}

    }
}