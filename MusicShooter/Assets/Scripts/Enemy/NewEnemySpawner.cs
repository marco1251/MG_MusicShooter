using UnityEngine;
using System.Collections;

public class NewEnemySpawner : MonoBehaviour
{

    public Camera mainCam; //reference to main camera

    public GameObject enemy; //referance to enemy prefab
    public Transform[] spawnPoints; //array of spawnpoints

    //spawn transforms that will change position when screen changes size
    public Transform Lspawn1;
    public Transform Lspawn2;
    public Transform Lspawn3;
    public Transform Lspawn4;
    public Transform Lspawn5;
    public Transform Lspawn6;
    public Transform Lspawn7;
    public Transform Lspawn8;
    public Transform Lspawn9;

    public Transform Rspawn1;
    public Transform Rspawn2;
    public Transform Rspawn3;
    public Transform Rspawn4;
    public Transform Rspawn5;
    public Transform Rspawn6;
    public Transform Rspawn7;
    public Transform Rspawn8;
    public Transform Rspawn9;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 3, 1.5f); //spawn enemy
    }

    // Update is called once per frame
    void Update()
    {
        //position the transforms depending on screen size
        SetSpawnLocations();
    }

    void SetSpawnLocations()
    {
        //placing spawn at the left side of the screen, each spawn with a different y position
        Lspawn1.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
        Lspawn2.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 1f);
        Lspawn3.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 2f);
        Lspawn4.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 3f);
        Lspawn5.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 4f);
        Lspawn6.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, -1f);
        Lspawn7.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, -2f);
        Lspawn8.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, -3f);
        Lspawn9.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, -4f);

        //placing spawn at the right side of the screen, each spawn with a different y position
        Rspawn1.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
        Rspawn2.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 1f);
        Rspawn3.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 2f);
        Rspawn4.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 3f);
        Rspawn5.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 4f);
        Rspawn6.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, -1f);
        Rspawn7.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, -2f);
        Rspawn8.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, -3f);
        Rspawn9.transform.position = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, -4f);
    }

    void Spawn()
    {
        //previous code that spawned enemies at a random spawnpoint (currently not working)
        //int SpawnSelect = Random.Range(0, spawnPoints.Length); //int to determine which spawn is used 

        //Instantiate(enemy, spawnPoints[SpawnSelect].position, spawnPoints[SpawnSelect].rotation); //spawn enemy at the selected spawn
    }
}
