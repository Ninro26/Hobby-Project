using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static PlayerMove instance;
    public float speed;
    private float jumpForce;
    private float movementInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    private float checkRadius;
    private LayerMask whatIsGround;
    private int extraJumps;
    private bool spawnDust = false;
    public GameObject dustEffect;
    private bool landed = false;
    public Animator animator;
    
    // Use this for initialization


    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        movementInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementInput * speed, rb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(movementInput));
        if (facingRight == true && movementInput < 0    )
        {

            Flip();


        }
        else if (facingRight == false && movementInput > 0)
        {
            Flip();

        }




    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }

    // Update is called once per frame
    void Update()
    {



        if (isGrounded == true)
        {
            extraJumps = 1;
            if (spawnDust == true && landed == true)
            {
                Instantiate(dustEffect, groundCheck.position, Quaternion.identity);

            }


        }

        if (Input.GetButtonDown("Jump") && extraJumps > 0)
        {
            spawnDust = false;
            rb.velocity = Vector2.up * jumpForce;
            extraJumps -= 1;
        }
        else if (Input.GetButtonDown("Jump") && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }




    }
}
