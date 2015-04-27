using UnityEngine;
using System.Collections;

public class Station : MonoBehaviour
{
    public GUIText GuiHealth;
    public GUIText GuiLose;

    int health;

    AudioSource deathAudioSource; //reference to audio source
    public AudioClip deathAudio; //reference to audio clip

    // Use this for initialization
    void Start()
    {
        health = 100;
        GuiHealth.text = "Station Health: " + health.ToString();
        GuiLose.text = "You Lose!";
        GuiHealth.enabled = true;
        GuiLose.enabled = false;

        deathAudioSource = this.gameObject.AddComponent<AudioSource>();
        deathAudioSource.clip = deathAudio;
    }

    void Update()
    {
        GuiHealth.text = "Station Health: " + health.ToString();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //subtrack a life from lives when player touches an enemy
        if (other.gameObject.tag == ("Enemy"))
        {
            health -= 20;
            Hit();

            deathAudioSource.PlayOneShot(deathAudio);

            Destroy(other.gameObject);
        }
    }

    void Hit()
    {
        if(health <= 0)
        {
            GuiHealth.text = "Station Health: 0";
            GuiLose.enabled = true;
            Invoke("Reset", 2f);
        }
    }

    void Reset()
    {
        Application.LoadLevel(0);
    }
}
