﻿using UnityEngine;
using System.Collections;

public class Station3 : MonoBehaviour {

    public GameObject enemy;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 8, 2);
    }


    void Spawn()
    {
        Instantiate(enemy, this.transform.position, this.transform.rotation);
    }
}
