using UnityEngine;
using System.Collections;

public class LevelMusic : Health
{
    AudioSource levelAudioSource; //reference to audio source
    public AudioClip levelAudioClip; //reference to level music audio clip

    AudioSource loseAudioSource; //reference to audio source
    public AudioClip loseAudioClip; //reference to lose state audio clip

    // Use this for initialization
    void Start()
    {
        //defining level audio
        levelAudioSource = this.gameObject.AddComponent<AudioSource>();
        levelAudioSource.clip = levelAudioClip;

        //defining lose audio
        loseAudioSource = this.gameObject.AddComponent<AudioSource>();
        loseAudioSource.clip = loseAudioClip;

    }

    // Update is called once per frame
    void Update()
    {
        //play level audio when player has more than 0 lives
        if (lives > 0)
        {
            levelAudioSource.PlayOneShot(levelAudioClip);
        }
        //play lose audio when player runs out of lives 
        else if (lives <= 0)
        {
            levelAudioSource.mute = true;
            loseAudioSource.PlayOneShot(loseAudioClip);
        }
    }
}
