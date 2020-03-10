using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] private float moveSpeed;
    float x,y;
    float speed = 0.4f;

    public GameObject ship;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        ship = GameObject.Find("Carrier 1");
        x = ship.transform.position.x;
        y = ship.transform.position.y;
        Physics2D.gravity = Vector2.zero;
    }

    void Update()
    {
        rb2d.AddForce(transform.right * -moveSpeed);
        x -= speed;
        transform.position = new Vector3(x,y,0); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Asteroid")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
