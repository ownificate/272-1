using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    [SerializeField] private KeyCode jump; //What button lets you jump
    [SerializeField] private int numJumps; //Max jump count
    private float jumpSpeed; //how high you jump
    private float g; //strength of gravity
    private bool isOnGround;
    private Rigidbody2D rb2d;
    private float verticalValue;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        numJumps = 2;
        jumpSpeed = 5f;
    }
    
    void Update()
    {
        checkForJump();
    }

    private void FixedUpdate()
    {
        //change g whilst falling
        if(rb2d.velocity.y < 0)
            rb2d.gravityScale = 2;
        else
            rb2d.gravityScale = 1f;

        rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y + verticalValue);
    }

    private void checkForJump()
    {
        if(Input.GetKeyDown(jump))
        {
            if(isOnGround && numJumps > 0)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                verticalValue = jumpSpeed;
                numJumps--;
                isOnGround = false;
            }
        }
        else
            verticalValue = 0;
    }

    //Detection for ground collision
    void OnTriggerEnter2D(Collider2D other)
    {
        print("test");
        if(other.CompareTag("walkable"))
        {
            numJumps = 2;
            isOnGround = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("enemy"))
            print("painful!");
    }
}
