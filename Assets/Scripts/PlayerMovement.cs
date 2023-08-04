using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] private float speed = 8f;
    [SerializeField] private bool isOnWall;
    private float speedBackUp;

    private void Start()
    {
        speedBackUp = speed;
        isOnWall = false;
        rb.velocity = Vector3.left * speed;
    }

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //rb.velocity = Vector3.up * speed;

        if (Input.GetKeyDown(KeyCode.Space) && isOnWall)
        {
            Jump();
            isOnWall = false;
            speed = speedBackUp;
        }
    }

    private void Jump() 
    {
        rb.velocity = Vector3.right * speed;
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
