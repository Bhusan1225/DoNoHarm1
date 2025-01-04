using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SeedsTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Seed collected!");

            
            PlantController plantController = FindObjectOfType<PlantController>();
            if (plantController != null)
            {
                plantController.AddGrassFromSeed();
            }

            
            seedSpawning seedSpawner = FindObjectOfType<seedSpawning>();
            if (seedSpawner != null)
            {
                seedSpawner.SpawnSeed();
            }

           
            Destroy(gameObject);
        }
    }
}

