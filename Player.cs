using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //                                      1. YÖNTEM
    /*public float harekethizi = 200f;
    public float yatayhareket = 50f;

    public  Rigidbody rb;

    private void start() {

        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -harekethizi * Time.deltaTime);

        if(Input.GetKey("d") )
        {
            rb.AddForce( yatayhareket*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce( -yatayhareket * Time.deltaTime, 0, 0);
        }
    } 
    */
    private CharacterController controller;
    public float speed  = 5.0f;
    private Vector3 moveVector;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    private void Update()
    {
        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }


        // X -Left and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

        // Y -Up and Down
        moveVector.y = verticalVelocity;

        // Z -Forwar and Backward
        moveVector.z = speed;


        controller.Move(moveVector*Time.deltaTime);
    }

    public void SetSpeed(float modifier)
    {
        speed = 2.0f + modifier;
    }

}
