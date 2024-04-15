using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; 

    public GameObject[] obstacleInstances;
    public int numberOfInstances = 5;
    public int instanceIndex = 0;

    public float timeToSpawn;
    void Start()
    {
        timeToSpawn = Random.Range(1.0f, 3f);

        obstacleInstances = new GameObject[numberOfInstances]; //new array with the size of numberOfInstances
        for (int i = 0; i < numberOfInstances; i++)
        {
            obstacleInstances[i] = Instantiate(obstaclePrefab); //fills the array with obstacle instances
            obstacleInstances[i].transform.position = transform.position; //sets position of instances to spawner position
            obstacleInstances[i].SetActive(false);
        }
    }

    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if(timeToSpawn <= 0)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(1.0f, 3f);
        }
    }

    void SpawnObstacle()
    {
        obstacleInstances[instanceIndex].SetActive(true);
        obstacleInstances[instanceIndex].transform.position = transform.position;
        instanceIndex++;
        if (instanceIndex == numberOfInstances)
        {
            instanceIndex = 0;
        }
    }
}
