using UnityEngine;
using System.Collections;

public class AudioMaster : MonoBehaviour
{
    AudioSource audioSource; //reference to audio source
    public AudioClip audioClip; //reference to audio clip

    // Use this for initialization
    void Start()
    {
        //audioSource = new AudioSource();
        audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.PlayOneShot(audioClip);
        
    }

}
