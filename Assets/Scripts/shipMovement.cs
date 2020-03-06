using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    [SerializeField]
    //private float horizValue, vertiValue;
    private Rigidbody2D rb2d;
    public float speed;

    [SerializeField] private float moveForce;
    [SerializeField] private float h, v;
    [SerializeField] private bool isHoldingKey = false;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0f;
    }

    private void FixedUpdate()
    {
        //applies force to object to move it based on axis input
        rb2d.AddForce(new Vector2(h, v));
    }

    void Update()
    {
        getInput();
        //Vector2 targetVelocity = new Vector2(h, v);
        //GetComponent<Rigidbody2D>().velocity = targetVelocity * speed;
    }

    private void getInput()
    {
        h = Input.GetAxis("Horizontal") * moveForce;
        v = Input.GetAxis("Vertical") * moveForce;
    }
}
