using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] duckPrefabs;

    private float spawnLimitXLeft = -15;
    private float spawnLimitXRight = 15;
    private float spawnPosY = 5;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomDuck", startDelay, spawnInterval);
    }

    // spawn random duck at random x position at top of play area
    void SpawnRandomDuck()
    {
        int duckIndex = Random.Range(0, duckPrefabs.Length);

        // Generate random duck index and random spawn position

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(duckPrefabs[duckIndex], spawnPos, duckPrefabs[duckIndex].transform.rotation);

        /*GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = turret.transform.position;
            bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }*/
        

    }
}
