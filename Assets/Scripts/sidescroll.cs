using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidescroll : MonoBehaviour
{
    Rigidbody2D rb2d;
    float jumpSpeed = 8f;
    float xSpeed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpSpeed;
        }
        xSpeed = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(xSpeed,rb2d.velocity.y);     
    }

    

    void FixedUpdate()
    {
            
    }
}
