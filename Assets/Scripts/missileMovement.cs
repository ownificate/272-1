using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovement : MonoBehaviour
{
    float x,y;
    GameObject shipFiring;
    float speed = 0.04f;
    void Start()
    {
        x = shipFiring.transform.position.x - 1.5f;
        y = shipFiring.transform.position.y;
        shipFiring = GameObject.Find("shoooter");
    }

    // Update is called once per frame
    void Update()
    {
        x -= speed;
        y = transform.position.y;

        transform.position = new Vector3(x,y,0);
    }
}
