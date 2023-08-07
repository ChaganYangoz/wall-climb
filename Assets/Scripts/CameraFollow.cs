using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;

    

    float playerPosY;

    private void Update()
    {
        playerPosY = player.transform.position.y;
        
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(0, playerPosY +2.2f, -10);
    }
}
