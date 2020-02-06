using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speedX = 0.01f, speedY = 0.01f;
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        x += speedX;
        y += speedY;
        transform.position = new Vector3(x,y,0);
    }
}
