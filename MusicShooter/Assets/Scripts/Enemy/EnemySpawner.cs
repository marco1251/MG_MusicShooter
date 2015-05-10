using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy; //enemy prefab to be spawned
    public Transform[] spawnPoints; //array of spawnpoints
    private EnemyStationDestroy count; //count stations destroyed
    //public GameObject Station1;
    //public GameObject Station2;
    //public GameObject Station3;
    //public GameObject Station4;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 3, 1.5f); //spawn enemy
        count = GameObject.Find("stationCount").GetComponent<EnemyStationDestroy>(); //reference to station count gameobject 
    }

    void Update()
    {

    }

    void Spawn()
    {
        //int SpawnSelect = Random.Range(0, spawnPoints.Length); //int to determine which spawn is used 

        //if (spawnPoints[SpawnSelect].position != null)
            //Instantiate(enemy, spawnPoints[SpawnSelect].position, spawnPoints[SpawnSelect].rotation); //spawn enemy at the selected spawn


    }
}
