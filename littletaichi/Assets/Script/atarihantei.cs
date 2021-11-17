using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atarihantei : MonoBehaviour
{

    GameObject Ball;
 
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

        var x = this.transform.position.x;
        var y = this.transform.position.y;

        Vector2 ob = this.transform.position;
        Vector2 ball = Ball.transform.position;
        var bally = Ball.transform.position.y;
        if (ob==ball)
        {
            ball = new Vector2(x+10, y+10); ;
            Debug.Log("atari");
        }
    }
}
