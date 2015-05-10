using UnityEngine;
using System.Collections;

public class Station1 : MonoBehaviour
{

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 3, 6);
    }


    void Spawn()
    {
        Instantiate(enemy, this.transform.position, this.transform.rotation);
    }
}
