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
        int index;
        index = Random.Range(0, 2);
        if (index == 0)
        {
            Instantiate(prefabs[index], RandomPlatformSpawnPos(), prefabs[index].transform.rotation);
        }
        /*else if (index == 1)
        {
            if (RandomObstacleSpawnPos().x > 0)
            {
                Instantiate(prefabs[index], RandomObstacleSpawnPos(), Quaternion.Euler(new ?Vector3(0, 180, 0)));
            }
            Instantiate(prefabs[index], RandomObstacleSpawnPos(), prefabs[index].transform.rotation);
        }*/
        
    }

    Vector3 RandomPlatformSpawnPos() 
    {
        int index;
        index = Random.Range(0, 2);
        float spawnPosX = spawnPos[index].transform.position.x;

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
    Vector3 RandomObstacleSpawnPos() 
    {
        int index;
        index = Random.Range(0, 2);
        float spawnPosX = spawnPos[index].transform.position.x;

        if (index == 0)
        {
            spawnPosX = spawnPos[index].transform.position.x + 2f;
        }
        else if (index == 1)
        {
            spawnPosX = spawnPos[index].transform.position.x - 2;
        }


        return new Vector3(spawnPosX, spawnPos[index].transform.position.y + 6, 0);
    }

    
}
