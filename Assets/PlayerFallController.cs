using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallController : MonoBehaviour
{

    public HealthController healthController;
    public GameObject gameOverPanel;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthController.healthBar.Count == 1)
            {

                gameOverPanel.SetActive(true);
            }
            else
            {
                healthController.Reduce();
            }
        }
    }
}
