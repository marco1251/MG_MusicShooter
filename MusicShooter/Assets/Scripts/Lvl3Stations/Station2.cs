using UnityEngine;
using System.Collections;

public class Station2 : MonoBehaviour {

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 6, 3);
    }


    void Spawn()
    {
        Instantiate(enemy, this.transform.position, this.transform.rotation);
    }
}
