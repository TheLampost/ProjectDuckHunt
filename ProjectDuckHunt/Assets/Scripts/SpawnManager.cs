using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] duckPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
