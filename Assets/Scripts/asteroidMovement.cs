using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{
    float speed = 0.08f;
    public float y;
    void Start()
    {

    }

    void Update()
    {
        float x = transform.position.x;
        x += speed;
        //Upon this line running, the character will fly to the left.
        transform.position = new Vector3(x,y,0);
    }
}
