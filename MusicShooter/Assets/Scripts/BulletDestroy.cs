using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("Destroy", 1.5f); //destroy the bullet after some time seconds
    }

    void Destroy() //destroy function to invoke
    {
        Destroy(this.gameObject); //this.gameobject attached to bullet prefab
    }
}
