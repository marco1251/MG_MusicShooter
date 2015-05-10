using UnityEngine;
using System.Collections;

public class Level2Manager : MonoBehaviour
{
    private EnemyCount enemyCount;

    void Awake()
    {
        enemyCount = GameObject.Find("enemyCount").GetComponent<EnemyCount>(); //reference to game object
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCount.enemyCount == 30)
        {
            Application.LoadLevel("2DSceneLvl3");
        }
    }
}
