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
    }

    private void Update()
    {
   
    }
    private void FixedUpdate()
    {
    
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
