using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   
    [Header("Audio source(speaker)")]

    [SerializeField] private AudioSource backgroundAudioSource;
    [SerializeField] private AudioSource soundFXAudioSource;

    
    [Header ("Audio clip(CD)")]
    [SerializeField] private AudioClip healthCollectedAudio;
    [SerializeField] private AudioClip gameOverAudio;
    [SerializeField] private AudioClip buttonClickAudio;
    [SerializeField] private AudioClip alaramAudio;
    [SerializeField] private AudioClip winAudio;

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

