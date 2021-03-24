using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 6f;
   // public float speedRun = 12f;

    public float gravity = -9.8f;
    public float jumpHeight = 3f;


    public Transform groundCheck;
    public float groundDistance;

    public Transform leftWallCheck;
    public Transform rightWallCheck;



    public LayerMask groundMask;

    Vector3 velocity;
    bool isGround;
    bool isLWall;
    bool isRWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BasicMovement();
        WallMovement();
    }

    private void BasicMovement()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGround)
        {
            SoundManager.playSound("jump");
            velocity.y = Mathf.Sqrt(jumpHeight * -0.5f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void WallMovement()
    {
        isLWall = Physics.CheckSphere(leftWallCheck.position, groundDistance, groundMask);
        isRWall = Physics.CheckSphere(rightWallCheck.position, groundDistance, groundMask);

        if (Input.GetKey(KeyCode.Space))
        {
            if (isLWall)
                 {
                     velocity.y = 2f;
                    
                 }
            else if (isRWall)
            {
                velocity.y = 2f;
                
            }
        }
       
        else
        {
            
        }
      
    }
}
