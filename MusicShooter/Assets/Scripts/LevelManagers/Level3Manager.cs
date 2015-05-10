using UnityEngine;
using System.Collections;

public class Level3Manager : MonoBehaviour
{

    private EnemyStationDestroy count; //count stations destroyed
    public GUIText guiLose; //reference to guitext

    // Use this for initialization
    void Start()
    {
        count = GameObject.Find("stationCount").GetComponent<EnemyStationDestroy>(); //reference to station count gameobject 
        guiLose.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //you win when all 4 stations are destroyed
        if (count.count == 4)
        {
            guiLose.text = "You Win!";
            guiLose.enabled = true;
            Invoke("Reset", 2);
        }

    }

    //reset function
    void Reset()
    {
        Application.LoadLevel(0);
    }
}
