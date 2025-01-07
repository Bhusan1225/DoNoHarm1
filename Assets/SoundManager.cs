using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   
    [Header("Audio source(speaker)")]
    public AudioSource backgroundAudioSource;
    public AudioSource soundFXAudioSource;

    
    [Header ("Audio clip(CD)")]
    public AudioClip healthCollectedAudio;
    public AudioClip gameOverAudio;
    public AudioClip buttonClickAudio;



    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        PlayBackgroundMusic();
    }


    
    //background 
    public void PlayBackgroundMusic()
    {
        if (backgroundAudioSource != null && backgroundAudioSource.clip != null && !backgroundAudioSource.isPlaying)
        {
            backgroundAudioSource.Play();
        }
    }


    //sfx
    public void HealthCollectedAudio()
    {
        if (soundFXAudioSource != null && healthCollectedAudio != null)
        {
            soundFXAudioSource.PlayOneShot(healthCollectedAudio);
        }
    }
    public void PlayGameOverAudio()
    {
        if (soundFXAudioSource != null && gameOverAudio != null)
        {
            soundFXAudioSource.PlayOneShot(gameOverAudio);
        }
    }

    public void PlayButtonClickAudio()
    {
        if (soundFXAudioSource != null && buttonClickAudio != null)
        {
            soundFXAudioSource.PlayOneShot(buttonClickAudio);
        }
    }

    public void DestroySoundManager()
    {
        Destroy(gameObject);
    }
}

