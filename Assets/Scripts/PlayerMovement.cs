using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float horizontalmove = 0f;
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public bool jump = false;
    public float moveSpeed = 10f;
    public float jumpForce = 50f;
    public int jumpCount = 3;
    public bool OnGround;
    bool candoublejump;
    Rigidbody2D rigid;
    public Animator animator;
   

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


   
    public void OnLanding()
    {
        
        OnGround = true;
    }
    // Update is called once per frame


    private void FixedUpdate()
    {


        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
        // animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
        animator.SetBool("IsJumping", false);
    }
    void Update()
    {
      
        
        // left or right arrow keys
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;
         if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
          


        /*animator.SetFloat("Speed", Mathf.Abs(horizontalmove));

        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        if (OnGround == true && Input.GetButtonDown("Jump"))
        {
            jump = true;

            if (jump == true)
            {
                rigid.AddForce(new Vector2(0, jumpForce));
                animator.SetBool("IsJumping", true);
                if (Input.GetButtonDown("Jump"))
                {
                    jumpCount += 1;
                }
             
            }
        }
        
            //Jumping  
        /*    if (jumpCount > 3 || OnGround == true && Input.GetButtonDown("Jump"))
        {

                if (Input.GetButtonDown("Jump"))
                {
                    Debug.Log("jumptest");
                    rigid.AddForce(new Vector2(0, jumpForce));


                    // rigid.velocity = new Vector2(rigid.velocity.y, 0);
                    jump = true;
                    animator.SetBool("IsJumping", true);
                     jumpCount = + 1;
                }
            



                {
                    if (jump == true)
                    {

                        OnGround = false;
                        
                }


                    if (OnGround == true)
                    {

                        Debug.Log("grounded");
                        //rigid.AddForce(new Vector2(0, jumpForce));
                        candoublejump = false;
                        jump = false;
                        animator.SetBool("IsJumping", false);
                    }
                    /* else
                     {
                         if (candoublejump == true)
                         {


                             rigid.AddForce(new Vector2(0, jumpForce));
                         }
                         
                    // }
                }
            }
            */
        } 
    }


    

   
        

