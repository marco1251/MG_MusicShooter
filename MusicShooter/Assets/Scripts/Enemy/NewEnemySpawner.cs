using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewEnemySpawner : MonoBehaviour
{

    public Camera mainCam; //reference to main camera
    public GameObject enemy; //referance to enemy prefab
    public Transform[] spawnPoints; //array of spawnpoints

    // Use this for initialization
    void Start()
    {
        SetSpawnLocations(); //set initial spawn locations
        InvokeRepeating("Spawn", 3, 1.5f); //spawn enemy
    }

    // Update is called once per frame
    void Update()
    {
        //position the transforms depending on screen size
        SetSpawnLocations();
    }

    //setting spawn location of each spawn point in the array
    void SetSpawnLocations()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i <= 8) //left side spawns
            {
                //placing spawn at the left side of the screen, each spawn with a different y position
                spawnPoints[i].transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, -4f + i);
            }

            if (i > 8) //right side spawns
            {
                //placing spawn at the right side of the screen, each spawn with a different y position
                spawnPoints[i].transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, (-4f + (i - 9)));
            }
        }
    }

    void Spawn()
    {
        //previous code that spawned enemies at a random spawnpoint
        int SpawnSelect = Random.Range(0, spawnPoints.Length); //int to determine which spawn is used 

        Instantiate(enemy, spawnPoints[SpawnSelect].position, spawnPoints[SpawnSelect].rotation); //spawn enemy at the selected spawn
    }
}
