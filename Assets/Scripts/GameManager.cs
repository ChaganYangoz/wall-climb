using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;

    public float n;


    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 2f, 2f);
    }
    void SpawnObstacle() 
    {
        Instantiate(prefabs[0], RandomSpawnPos() , prefabs[0].transform.rotation, transform);
    }

    Vector3 RandomSpawnPos() 
    {
        int randomPosX;
        randomPosX = Random.Range(0, 11);
        return new Vector3(randomPosX, 0, 0);
    }

    
}
