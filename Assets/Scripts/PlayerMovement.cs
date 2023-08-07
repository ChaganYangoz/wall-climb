using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject border;
    WallManager wallManager;

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
        if (transform.position.y > border.transform.position.y) 
        {
            //Debug.Log("UpdateWalls");
            //wallManager.UpdateWalls();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnWall)
        {
            Jump();
            isOnWall = false;
            speed = speedBackUp;
        }
    }
    private void FixedUpdate()
    {
        if (isOnWall)
        {
            rb.velocity = new Vector3(rb.velocity.x, verticalSpeed, 0);
        }
        else if (!isOnWall)
        {
            Gravity();
        }
        
    }

    private void Jump() 
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
        rb.AddForce(Vector3.up * verticalSpeed, ForceMode.Impulse);
    }

    private void Gravity() 
    {
        rb.AddForce(Vector3.down * verticalSpeed / 2.5f, ForceMode.Acceleration);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WallRight")
        {
            isOnWall = true;
            speed = -speed;   
        }
        if (collision.gameObject.tag == "WallLeft") 
        {
            isOnWall= true;
        }
    }

}
