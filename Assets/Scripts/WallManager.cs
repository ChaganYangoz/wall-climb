using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    [SerializeField] GameObject anchor;
    [SerializeField] GameObject player;
    [SerializeField] GameObject border;
    

    private void Awake()
    {
        gameObject.transform.position = anchor.transform.position;
    }

    private void Update()
    {
        if (player.transform.position.y > border.transform.position.y)
        {
            UpdateWalls();
        }   
    }
    public void UpdateWalls() 
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
        border.transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
    }
}

