using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTrigger : MonoBehaviour
{
    private bool isHeartTaken = false;


    private void Start()
    {
        
        StartCoroutine(DestroyHeart(5f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You get one Health....");

            HealthController healthController = FindAnyObjectByType<HealthController>();

            healthController.Grow();

            
            SoundManager soundManager = FindAnyObjectByType<SoundManager>();
            soundManager.HealthCollectedAudio();

            HeartSpawn heartSpawner = FindAnyObjectByType<HeartSpawn>();
            if (heartSpawner != null)
            {
                heartSpawner.NotifyHeartTaken();
            }
            Destroy(gameObject);
        }
    }


    private IEnumerator DestroyHeart(float delay)
    {
        
        yield return new WaitForSeconds(delay);

        
        if (!isHeartTaken)
        {
            Debug.Log("Heart was not taken, ready for next spawn.");

            HeartSpawn heartSpawner = FindAnyObjectByType<HeartSpawn>();
            if (heartSpawner != null)
            {
                heartSpawner.NotifyHeartTaken();
            }

            Destroy(gameObject);
        }
    }
}

