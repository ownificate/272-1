using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode shoot, jump;
    float horizValue, vertiValue;
    Rigidbody2D rb2d;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        horizValue = Input.GetAxisRaw("Horizontal");
        vertiValue = Input.GetAxisRaw("Vertical");
        Vector2 targetVelocity = new Vector2(horizValue, vertiValue);
        GetComponent<Rigidbody2D>().velocity = targetVelocity * speed;
    }

    void FixedUpdate()
    {
        //setVelocity();
    }

    void checkForPress()
    {
        if(Input.GetKeyDown(shoot))
            Debug.Log("You did it!");
        if(Input.GetKeyDown(jump))
            Debug.Log("You be a skilled jumper there matey.");
    }

    void peekAxis()
    {
        horizValue = Input.GetAxis("Horizontal");
        vertiValue = Input.GetAxis("Vertical");
        //Debug.Log(horizValue + " " + vertiValue);
    }

    void move()
    {
        transform.position += new Vector3(horizValue,vertiValue,0);
    }

    void setVelocity()
    {
        rb2d.velocity = new Vector2(horizValue, vertiValue);
    }
}
