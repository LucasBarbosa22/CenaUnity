using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcamera : MonoBehaviour
{

    public Vector3 ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = 0.0379999f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.S))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = -0.03f;

            transform.Translate(ball);
        }
    }
}
