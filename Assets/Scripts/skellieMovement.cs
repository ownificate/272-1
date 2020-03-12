using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skellieMovement : MonoBehaviour
{
    public GameObject missile;
    public GameObject shooter;
    public LayerMask layerMask;
    public SpriteRenderer spriteRenderer;
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    public float jumpSpeed = 8f;
    float x;
    public float speed;
    public bool isFacingRight, isHoldingKey;
    Animator anim;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if(isOnGround() && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpSpeed;
        }
        if(rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = 2f;
        }
        animate();
        move();
        fire();
        updateAxes();
    }

    void updateAxes()
    {
        x = Input.GetAxis("Horizontal");
    }

    private void animate()
    {
        anim.SetFloat("xSpeed", Mathf.Abs(rb2d.velocity.x));
    }

    private bool isOnGround()
    {
        RaycastHit2D hit2D = Physics2D.BoxCast(bc2d.bounds.center,bc2d.bounds.size,0f,Vector2.down,.1f,layerMask);
        return (hit2D.collider == null) ? false : true;
    }

    private void move()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            isFacingRight = false;
            spriteRenderer.flipX = true;
            //transform.Rotate(0,180,0); <-- Better because it rotates children
        }
        else 
        {
            if(Input.GetKey(KeyCode.D))
            {
                rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
                isFacingRight = true;
                spriteRenderer.flipX = false;
            }
            else
            {
                if(rb2d.velocity.x > 0)
                    rb2d.velocity = new Vector2(rb2d.velocity.x - 0.8f,rb2d.velocity.y);
                else
                    rb2d.velocity = new Vector2(0,rb2d.velocity.y);
            }
        }
    }

    private void fire()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject tmpMissile;
            if (!isFacingRight)
            {
                tmpMissile = Instantiate(missile, shooter.transform.position, Quaternion.Euler(0, 0, 180)) as GameObject;
                Destroy(tmpMissile, 2.0f);
            }
            else
            {
                tmpMissile = Instantiate(missile, shooter.transform.position, Quaternion.identity) as GameObject;
                Destroy(tmpMissile, 2.0f);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            isHoldingKey = true;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Gate") && isHoldingKey)
        {
            isHoldingKey = false;
            Destroy(other.gameObject);
        }
    }
}
