using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    [SerializeField] GameObject anchor;

    private void Awake()
    {
        gameObject.transform.position = anchor.transform.position;
    }
}
