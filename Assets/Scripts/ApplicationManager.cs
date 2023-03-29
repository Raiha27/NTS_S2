using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ApplicationManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform cam;

    public int enemyNumber = 10;
    public float spawnRange = 3f;

    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyNumber; i++)
        {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y = cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
            float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }

    public void Start()
    {
        SpawnEnemy();
    }
}
