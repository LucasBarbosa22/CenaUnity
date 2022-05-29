using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptscale : MonoBehaviour
{

    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotateChange;

    void Start()
    {
        
    }

    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
        transform.Rotate(rotateChange);
    }
}
