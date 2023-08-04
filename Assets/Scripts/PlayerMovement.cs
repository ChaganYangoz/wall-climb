using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] private float speed;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private bool isOnWall;

    private float speedBackUp;

    private void Start()
    {
        speed = 16f;
        verticalSpeed = 4f;
        speedBackUp = speed;
        isOnWall = false;
        rb.velocity = new Vector3(speed / 2, rb.velocity.y, rb.velocity.z);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnWall)
        {
            Jump();
            isOnWall = false;
            speed = speedBackUp;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, verticalSpeed , 0);
    }

    private void Jump() 
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "WallRight")
        {
            isOnWall = true;
            speed = -speed;   
        }
        if (collision.gameObject.name == "WallLeft") 
        {
            isOnWall= true;
        }
    }

}
