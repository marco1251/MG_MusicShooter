using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnPoints;
    public float initialSpawn = .25f;
    public float spawnDelay = .25f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", initialSpawn, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        int SpawnSelect = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[SpawnSelect].position, spawnPoints[SpawnSelect].rotation);
    }
}
