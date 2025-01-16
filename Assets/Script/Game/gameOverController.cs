using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{

    [SerializeField] private PlantController plantController;

    [SerializeField] private UIHealthController healthController;

    [SerializeField] private float delayPupup = 2f;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject LowPlantpopupPanel;

    [Header("Sound Manager")]
    [SerializeField] public GameSoundManager soundManager;

    
    void Update()
    {
        LowPlantPopup();

        if (plantController.Plant.Count ==1)
        if (healthController.healthBar.Count <1)
        {
            soundManager.PlayGameOverAudio();
            gameOverPanel.SetActive(true);
        }
    }

    void LowPlantPopup()
    {
        if (plantController.Plant.Count == 2)
        {
            soundManager.AlaramAudioAudio();
            LowPlantpopupPanel.SetActive(true);
            

        }else
        {
            LowPlantpopupPanel.SetActive(false);
        }
    }

    void DeactivatePopup()
    {
        LowPlantpopupPanel.SetActive(false);
    }

}
