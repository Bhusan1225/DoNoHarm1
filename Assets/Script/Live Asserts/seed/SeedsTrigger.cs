using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SeedsTrigger : MonoBehaviour
{

    GameSoundManager soundManager;
    PlantController plantController;

    private void Start()
    {
        soundManager = FindAnyObjectByType<GameSoundManager>();
        plantController = FindAnyObjectByType<PlantController>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Seed collected!");
            
            soundManager.HealthCollectedAudio();

            
            if (plantController != null)
            {
                plantController.AddGrassFromSeed();
            }

            
            SeedSpawnController seedSpawner = FindObjectOfType<SeedSpawnController>();
            if (seedSpawner != null)
            {
                seedSpawner.RandomSeedSpawn();
            }

           
            Destroy(gameObject);
        }
    }
}

