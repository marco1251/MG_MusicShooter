using UnityEngine;
using System.Collections;

public class CountGUI : MonoBehaviour
{
    private EnemyCount count; //count stations destroyed
    public GUIText countGUI;
    // Use this for initialization
    void Start()
    {
        count = GameObject.Find("enemyCount").GetComponent<EnemyCount>(); //reference to station count gameobject 
        countGUI.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        countGUI.text = "Enemies Left: " + (30 - count.enemyCount);
    }
}
