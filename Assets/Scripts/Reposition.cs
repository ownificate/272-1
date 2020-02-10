using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    float speed = 0.02f;
    void Start()
    {
        transform.position = new Vector3(0,0,0);
        Debug.Log(transform.position);
    }

    void Update()
    {
        float x = transform.position.x;
        x += speed;
        //Upon this line running, the character will fly to the left.
        transform.position = new Vector3(x,0,0);
    }
}
