using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerUp;

    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 14.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    private float enemySpawnTime = 2.0f;
    private float powerupSpawnTime = 8.0f;
    private float startDelay = 1.0f;
    
    void Start()
    {
        InvokeRepeating("spawnPowerup", startDelay, powerupSpawnTime);
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }
    
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void spawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerUp, spawnPos, powerUp.gameObject.transform.rotation);
    }
}
