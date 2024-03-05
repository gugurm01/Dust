using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[System.Serializable]

public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public float spawnInterval;
    public int enemiesLifes;
    public GameObject[] typeOfEnemies;
    
}

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] Wave[] waves;
    public Transform[] spawnPoits;

    private Wave currentWave;
    private int currentWaveNumber;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        currentWave = waves[currentWaveNumber];
    }

    void SpawnWave()
    {
        GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
        Transform randomPoint = spawnPoits[Random.Range(0, spawnPoits.Length)];
        Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
    }
}