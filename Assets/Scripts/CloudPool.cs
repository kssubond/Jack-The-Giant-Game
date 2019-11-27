using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudPool : MonoBehaviour
{
    public GameObject[] cloudPrefabs;
    public GameObject coin;

    public int cloudPoolSize = 4;
    public static float spawnRate = 2.5f;
    public int cloudMin = -2;
    public int cloudMax = 2;

    public float timer;
    public float waitingTime;

    private GameObject[] clouds;

    private int currentCloud = 0;

    private Vector2 objectPoolPosition = new Vector2(0, 5.5f);
    private float spawnYPosition = -5.5f;
    private float timeSinceLastSpawned;
    private int lastNumber;


    void Start()
    {
        timeSinceLastSpawned = 0f;

        clouds = new GameObject[cloudPrefabs.Length];

        for (int i = 0; i < cloudPrefabs.Length; i++)
        {
            clouds[i] = Instantiate(cloudPrefabs[GetRandom(0, cloudPrefabs.Length)], objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnXPosition = GetRandom(cloudMin, cloudMax);
            clouds[currentCloud].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentCloud++;

            if (currentCloud >= cloudPoolSize)
            {
                currentCloud = 0;
            }
        }

        CoinSpawnTimer();
    }

    int GetRandom(int min, int max)
    {
        int rand = Random.Range(min, max);
        while (rand == lastNumber)
            rand = Random.Range(min, max);
        lastNumber = rand;
        return rand;
    }

    void CoinSpawn()
    {
        Vector2 pos = new Vector2(GetRandom(-2,2), -6);
        Instantiate(coin, pos, Quaternion.identity);
    }

    void CoinSpawnTimer()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            CoinSpawn();
            timer = 0;
        }
    }
}
