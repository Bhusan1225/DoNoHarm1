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
    public AudioClip alaramAudio;
    public AudioClip winAudio;




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
    public void WinAudio()
    {
        if (soundFXAudioSource != null && winAudio != null)
        {
            soundFXAudioSource.PlayOneShot(winAudio);
        }
    }

    public void HealthCollectedAudio()
    {
        if (soundFXAudioSource != null && healthCollectedAudio != null)
        {
            soundFXAudioSource.PlayOneShot(healthCollectedAudio);
        }
    }
    public void AlaramAudioAudio()
    {
        if (soundFXAudioSource != null && alaramAudio != null)
        {
            soundFXAudioSource.PlayOneShot(alaramAudio);
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

