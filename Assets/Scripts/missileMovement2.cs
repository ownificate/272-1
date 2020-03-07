using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovement2 : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] private float moveSpeed;
    float x,y;
    float speed = 0.4f;

    bool isFacingRight;
    public GameObject ship;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.right * -moveSpeed);
        ship = GameObject.Find("Skellie_solo");
        x = ship.transform.position.x;
        y = ship.transform.position.y;
        isFacingRight = ship.GetComponent<skellieMovement>().isFacingRight;
    }

    void Update()
    {
        if(isFacingRight)
            x += speed;
        else
            x -= speed;
       transform.position = new Vector3(x,y,0); 
    }
}
