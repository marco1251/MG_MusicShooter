using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    private EnemyCount enemyCount; //reference to enemies destroyed counter

    void Awake()
    {
        enemyCount = GameObject.Find("enemyCount").GetComponent<EnemyCount>(); //reference to game object
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount.enemyCount == 30)
        {
            Application.LoadLevel("2DSceneLvl2"); //load level 2 when 30 enemies are destroyed
            enemyCount.enemyCount = 0; //reset coutner
        }
    }
}
