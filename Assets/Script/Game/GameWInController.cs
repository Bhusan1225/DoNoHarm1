using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinController : MonoBehaviour
{
    [SerializeField]private UIHealthController UIhealthController;

    [SerializeField]private GameObject gameWinPanel;

    [SerializeField]private GameSoundManager soundManager;
    // Update is called once per frame
    void Update()
    {
        if (UIhealthController.healthBar.Count == UIhealthController.maxHealth)
        {
            //GameSoundManager soundManager = FindAnyObjectByType<GameSoundManager>();
            soundManager.WinAudio();

            gameWinPanel.SetActive(true);
        }
    }
}
