using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] private float speed = 10f;

    private void FixedUpdate()
    {
        rb.velocity = Vector3.up * speed;
    }
}
