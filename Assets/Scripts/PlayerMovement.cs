using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] private float speed = 10f;
    

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //rb.velocity = Vector3.up * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump() 
    {
        if (gameObject.transform.position.x < -3)
        {
            rb.velocity = Vector3.right * speed;
        }
    }

}
