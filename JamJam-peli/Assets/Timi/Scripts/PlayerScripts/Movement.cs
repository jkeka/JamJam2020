using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables
    public CharacterController controller;

    public float runSpeed;
    public float speed;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Determine when player us touching ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        // apply gravity
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        //apply movement 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
           
        controller.Move(velocity * Time.deltaTime);

        //Running
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 3;
            }
            else
            {
                speed = 2;
            }

        }
    }
}
