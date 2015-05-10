using UnityEngine;
using System.Collections;

public class Station4 : MonoBehaviour {

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 4, 4);
    }


    void Spawn()
    {
        Instantiate(enemy, this.transform.position, this.transform.rotation);
    }
}
