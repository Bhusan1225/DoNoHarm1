using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinController : MonoBehaviour
{
    [SerializeField]private HealthUIController healthController;

    [SerializeField]private GameObject gameWinPanel;
    

    // Update is called once per frame
    void Update()
    {
        if (healthController.healthBar.Count == healthController.maxHealth)
        {
            SoundManager soundManager = FindAnyObjectByType<SoundManager>();
            soundManager.WinAudio();

            gameWinPanel.SetActive(true);
        }
    }
}
