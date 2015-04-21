using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{

    public Rigidbody bulletPrefab; //prefab of bullet
    public Transform bulletTransform; //transform for bullet prefab 

    AudioSource BulletAudioSource; //audio source
    public AudioClip bulletAudio; //audio for bullet shooting

    //bool isShooting; //checks if shooting 

    void Start()
    {
        BulletAudioSource = this.gameObject.AddComponent<AudioSource>(); //audio source
        BulletAudioSource.clip = bulletAudio; //audio clip

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shoot(); //shoot
        AudioManager(); //play audio when shooting

    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //get up arrow key
        {
            Rigidbody bulletInstance; //creating rigidbody
            bulletInstance = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation) as Rigidbody; //instantiate the rigidbody
            bulletInstance.AddForce(bulletTransform.up * 1000); //add force in up direction       
        }

        else if (Input.GetKey(KeyCode.DownArrow)) //shoot down
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation) as Rigidbody;
            bulletInstance.AddForce(bulletTransform.up * 1000);
        }

        else if (Input.GetKey(KeyCode.LeftArrow)) // shoot left
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation) as Rigidbody;
            bulletInstance.AddForce(bulletTransform.up * 1000);
        }

        else if (Input.GetKey(KeyCode.RightArrow)) //shoot right
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bulletPrefab, bulletTransform.position, bulletTransform.rotation) as Rigidbody;
            bulletInstance.AddForce(bulletTransform.up * 1000);
        }
    }

    void AudioManager()
    {
        //play audio when key is held down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            BulletAudioSource.PlayOneShot(bulletAudio);
        }
        //stop audio when key is released
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            BulletAudioSource.Stop();
        }

        //play audio when key is held down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            BulletAudioSource.PlayOneShot(bulletAudio);
        }
        //stop audio when key is released
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            BulletAudioSource.Stop();
        }

        //play audio when key is held down
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BulletAudioSource.PlayOneShot(bulletAudio);
        }
        //stop audio when key is released
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            BulletAudioSource.Stop();
        }

        //play audio when key is held down
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BulletAudioSource.PlayOneShot(bulletAudio);
        }
        //stop audio when key is released
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            BulletAudioSource.Stop();
        }
    }

}
