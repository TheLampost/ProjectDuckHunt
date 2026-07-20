using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] duckPrefabs;

    private float spawnMinZ = 20;
    private float spawnMaxZ = 10;
    private float spawnPosY = 15;
    private float spawnPosX = -20;

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

        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, Random.Range(spawnMinZ, spawnMaxZ));

        // instantiate ball at random spawn location
        Instantiate(duckPrefabs[duckIndex], spawnPos, duckPrefabs[duckIndex].transform.rotation);

    }
}
