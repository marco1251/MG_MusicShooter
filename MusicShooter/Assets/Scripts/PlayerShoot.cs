using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	public Rigidbody bulletPrefab; //prefab of bullet
	public Transform bulletUp; //transform for prefab to shoot up
	public Transform bulletDown; //transform for prefab to shoot down
	public Transform bulletLeft; //transform for prefab to shoot left
	public Transform bulletRight; //transform for prefab to shoot right
	
	// Update is called once per frame
	void FixedUpdate()
	{
		Shoot(); //shoot
	}
	
	void Shoot()
	{
		if (Input.GetKey(KeyCode.UpArrow)) //get up arrow key
		{
			Rigidbody bulletInstance; //creating rigidbody
			bulletInstance = Instantiate(bulletPrefab, bulletUp.position, bulletUp.rotation) as Rigidbody; //instantiate the rigidbody
			bulletInstance.AddForce(bulletUp.up * 1000); //add force in up direction
		}
		
		else if (Input.GetKey(KeyCode.DownArrow)) //shoot down
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, bulletDown.position, bulletDown.rotation) as Rigidbody;
			bulletInstance.AddForce(-bulletDown.up * 1000);
		}
		
		else if (Input.GetKey(KeyCode.LeftArrow)) // shoot left
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, bulletLeft.position, bulletLeft.rotation) as Rigidbody;
			bulletInstance.AddForce(-bulletDown.right * 1000);
		}
		
		else if (Input.GetKey(KeyCode.RightArrow)) //shoot right
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, bulletRight.position, bulletRight.rotation) as Rigidbody;
			bulletInstance.AddForce(bulletRight.right * 1000);
		}
	}
}
