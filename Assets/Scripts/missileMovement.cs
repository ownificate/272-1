using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovement : MonoBehaviour
{
    float x,y;
    float speed = 0.4f;

    public GameObject ship;
    void Start()
    {
        ship = GameObject.Find("Carrier 1");
        x = ship.transform.position.x;
        y = ship.transform.position.y;
        Physics2D.gravity = Vector2.zero;
    }

    void Update()
    {
       x -= speed;
       transform.position = new Vector3(x,y,0); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Asteroid")
        {
            print("test");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
