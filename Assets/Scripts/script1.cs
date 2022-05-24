using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{

    public Vector3 ball;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = 0.09f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.S))
        {
            ball.x = 0f;
            ball.y = 0f;
            ball.z = -0.03f;

            transform.Translate(ball);
        }

        if(Input.GetKey(KeyCode.A))
        {
            ball.x = 0f;
            ball.y = -0.3f;
            ball.z = 0f;

            transform.Rotate(ball);
        }

        if(Input.GetKey(KeyCode.D))
        {
            ball.x = 0f;
            ball.y = 0.3f;
            ball.z = 0f;

            transform.Rotate(ball);
        }
    }
}
