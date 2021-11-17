using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGravity : MonoBehaviour
{

    public float Gravity = 10;
    private int time = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Gravity--;
        //this.transform.position = new Vector3(0, Gravity * Time.deltaTime, 0);
        var body = GameObject.Find("Ball").GetComponent<Rigidbody>();
        body.WakeUp();
    }
}
