using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallController : MonoBehaviour
{
    [SerializeField]
    private HealthController healthController;
    [SerializeField]
    private GameObject gameOverPanel;

    [Header ("Sound Manager")]
    [SerializeField]private SoundManager soundManager;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthController.healthBar.Count == 1)
            {
                soundManager.PlayGameOverAudio();
                gameOverPanel.SetActive(true);

            }
            else if(healthController.healthBar.Count < 1)
            {

                healthController.Reduce();
            }
        }
    }
}
