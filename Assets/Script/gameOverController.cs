using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverController : MonoBehaviour
{
    public PlantController plantController;

    public HealthController healthController;

    public float delayPupup = 2f;

    public GameObject gameOverPanel;
    public GameObject LowPlantpopupPanel;

    [Header("Sound Manager")]
    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LowPlantPopup();

        if (plantController.Plant.Count ==1)

        {
            soundManager.PlayGameOverAudio();
            gameOverPanel.SetActive(true);
        }

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
