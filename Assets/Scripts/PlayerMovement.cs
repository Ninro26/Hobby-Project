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

    public Animator animator;
   

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        DontDestroyOnLoad(gameObject);
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
          


  
        } 
    }


    

   
        

