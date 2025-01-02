using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You get one Health....");

            HealthController healthController = FindAnyObjectByType<HealthController>();

            healthController.Grow();
            
            Destroy(gameObject);
        }
    }
}
