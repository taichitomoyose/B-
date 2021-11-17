using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2; 
    public AudioClip sound3;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        //if(other.gameObject.tag == "Item")
        //{
        //    audioSource.PlayOneShot(sound1);
        //    Debug.Log("当たった");
        //}
        if (other.gameObject.tag == "Wall")
        {
            audioSource.PlayOneShot(sound2);

        }
    }
}
