using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] List<GameObject> spawnPos;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 2f, 2f);
    }
    void SpawnObstacle() 
    {
        Instantiate(prefabs[0], RandomSpawnPos(), prefabs[0].transform.rotation);
    }

    Vector3 RandomSpawnPos() 
    {
        int index;
        float spawnPosX = 0;
        index = Random.Range(0, 2);

        if (index == 0)
        {
            spawnPosX = spawnPos[index].transform.position.x + 0.9f;
        }
        else if (index == 1)
        {
            spawnPosX = spawnPos[index].transform.position.x - 1;
        }


        return new Vector3(spawnPosX, spawnPos[index].transform.position.y + 6, 0);
    }

    
}
