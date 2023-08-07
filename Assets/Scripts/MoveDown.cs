using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    float speed = 4f;
    private void FixedUpdate()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
