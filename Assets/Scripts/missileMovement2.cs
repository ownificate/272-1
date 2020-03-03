using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovement2 : MonoBehaviour
{
    float x,y;
    float speed = 0.4f;

    bool isFacingRight;
    bool isJustFired;
    public GameObject ship;
    void Start()
    {
        ship = GameObject.Find("Skellie_solo");
        x = ship.transform.position.x;
        y = ship.transform.position.y;
        isJustFired = true;
    }

    void Update()
    {
        if(ship.GetComponent<skellieMovement>().isFacingRight)
            x += speed;
        else
            x -= speed;
       transform.position = new Vector3(x,y,0); 
    }
}
