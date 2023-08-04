using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] private float smoothTime = 0.04f;
    private Vector3 playerPos;
    private Vector3 velocity = Vector3.zero;

    float playerPosY;

    private void Update()
    {
        playerPosY = player.transform.position.y;
        playerPos = new Vector3(0, playerPosY, -10);
    }
    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, playerPos, ref velocity, smoothTime);
    }
}
