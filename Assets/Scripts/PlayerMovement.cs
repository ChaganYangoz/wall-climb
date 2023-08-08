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

    private void Awake()
    {
        rb.velocity = Vector3.right * speed;
    }
    private void Start()
    {
        speed = 16f;
        verticalSpeed = 4f;
        speedBackUp = speed;
        isOnWall = false;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnWall)
        {
            isOnWall = false;
            Jump();
            speed = speedBackUp;    
        }
    }
    private void FixedUpdate()
    {
    
    }
    void Jump() 
    {
        rb.velocity = Vector3.right * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WallRight")
        {
            if (speed == speedBackUp)
            {
                speed = -speed;
            }
            isOnWall = true;
              
        }
        if (collision.gameObject.tag == "WallLeft") 
        {
            isOnWall= true;
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(collision.gameObject);
        }
    }
   

}
