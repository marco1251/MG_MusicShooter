using UnityEngine;
using System.Collections;

public class PlayerDeath : Health
{

    //public int lives; //player lives
    public GUIText Guitext; //guitext keeping track of player lives
    public GUIText GuiLose; //failure text
    Vector3 respawn; //respawn player at center of the screen

    //
    public delegate void PlayerDeathHandler();
    public static event PlayerDeathHandler PlayerHit;

    AudioSource deathAudioSource; //reference to audio source
    public AudioClip deathAudio; //reference to audio clip


    // Use this for initialization
    void Start()
    {
        //defining lives and text
        //lives = 3;
        Guitext.text = "Lives: " + lives.ToString();
        GuiLose.text = "You Lose!";
        Guitext.enabled = true;
        GuiLose.enabled = false;
        respawn = new Vector3(0, 0, 0); //center of the screen

        deathAudioSource = this.gameObject.AddComponent<AudioSource>();
        deathAudioSource.clip = deathAudio;

    }


    void OnTriggerEnter(Collider other)
    {
        //subtrack a life from lives when player touches an enemy
        if (other.gameObject.tag == ("Enemy"))
        {

            //event manager
            if (PlayerHit != null)
            {
                PlayerHit(); //triggers event
                Hit(); //reduce lives
            }
        }

    }

    void Hit() //updates text when player is hit by enemy
    {
        lives -= 1;
        this.gameObject.transform.position = respawn; //move player to center of the screen
        Guitext.text = "Lives: " + lives.ToString(); //update guitext

        if (lives <= 0) //reset level when lives = 0
        {
            Guitext.text = "Lives: 0";
            GuiLose.enabled = true;
            Invoke("Reset", 2); //reset

        }

        deathAudioSource.PlayOneShot(deathAudio);

    }


    void Reset() // reset level when lives = 0
    {
        Application.LoadLevel(0);
    }
}
