using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy; //enemy prefab to be spawned
    public Transform[] spawnPoints; //array of spawnpoints
    public float initialSpawn = .25f; //time before spawning begins
    public float spawnDelay = .25f; //time between enemy spawns

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 3, 1.5f); //spawn enemy
    }

    void Spawn()
    {
        int SpawnSelect = Random.Range(0, spawnPoints.Length); //int to determine which spawn is used 

        Instantiate(enemy, spawnPoints[SpawnSelect].position, spawnPoints[SpawnSelect].rotation); //spawn enemy at the selected spawn
    }
}
