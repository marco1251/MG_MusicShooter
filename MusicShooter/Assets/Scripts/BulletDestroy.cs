using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		Invoke("Destroy", 2); //destroy the bullet after 2 seconds
	}
	
	void Destroy() //destroy function to invoke
	{
		Destroy(this.gameObject); //this.gameobject attached to bullet prefab
	}
}
