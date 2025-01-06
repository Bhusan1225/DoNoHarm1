using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTrigger : MonoBehaviour
{
    public HealthController healthController;

    public GameObject gameOverPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Animal hits player");
            healthController.Reduce();
        }
    }
}
