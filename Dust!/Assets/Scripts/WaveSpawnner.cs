using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}

public class WaveSpawnner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public Animator animator;
    public Text waveName;
    public Text waveNum;
    public Text inPauseWave;
    public Text inGameOverWave;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool canSpawn = true;
    private bool canAnimate;


    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        waveNum.text = waves[currentWaveNumber].waveName;
        inPauseWave.text = waves[currentWaveNumber].waveName;
        inGameOverWave.text = waves[currentWaveNumber].waveName;
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemies");
        if (totalEnemies.Length == 0)
        {
            if (currentWaveNumber + 1 != waves.Length)
            {
                if (canAnimate)
                {
                    waveName.text = waves[currentWaveNumber + 1].waveName;
                    animator.SetTrigger("WaveCompleted");
                    canAnimate = false;
                }

            }
            else
            {
                Debug.Log("GameFinish");
            }


        }

    }

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }


    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];;
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.noOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if (currentWave.noOfEnemies == 0)
            {
                canSpawn = false;
                canAnimate = true;
            }
        }

    }

}
