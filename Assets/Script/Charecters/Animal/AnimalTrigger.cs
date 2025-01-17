using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTrigger : MonoBehaviour
{
    [SerializeField]private UIHealthController healthController;
    [SerializeField]private GameObject gameOverPanel;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Animal hits player");
            healthController.Reduce();
        }
    }
}
