using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item2 : MonoBehaviour
{
    public float roundSpd = 100.0f;
    public GameObject particleObject;
    public AudioClip sound1;
    AudioSource audioSource;
    void OnTriggerEnter(Collider hit)
    {
        
        if (hit.CompareTag("Player"))
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            audioSource.PlayOneShot(sound1);
            this.gameObject.SetActive(false);
        }
    }
}

//Destroy(gameObject);