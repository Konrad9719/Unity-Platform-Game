using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public int movespeed;
    public int jumppower;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public int coins;
    public bool moveRight;
    public bool moveLeft;
    public int deaths;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movespeed = 3;
        jumppower = 5;

    }

    void Update()
    {
        if (moveLeft || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        if (moveRight || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        //if (Input.GetKey(KeyCode.Space) && onGround)
        if (Input.GetKey(KeyCode.Space))
        {
            jump();
        }
    }

    public void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumppower);
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius,
        whatIsGround);
    }

}
