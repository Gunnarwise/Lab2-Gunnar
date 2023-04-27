using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float xEnemySpawn = 24;
    private float zSpawnRange = 16;
    private float xPowerupRange = 5;
    private float zPowerupRange = 5;

    private float powerupSpawnTime = 5;
    private float enemySpawnTime = 1;
    private float startDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnEnemy()
    {
        float randZ = Random.Range(-zSpawnRange, zSpawnRange);
        int randIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(xEnemySpawn , 0.75f, randZ );

        Instantiate(enemies[randIndex], spawnPos, enemies[randIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randx = Random.Range(-xPowerupRange, xPowerupRange);
        float randz = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randx, 0.75f, randz);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
