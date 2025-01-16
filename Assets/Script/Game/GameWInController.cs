using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinController : MonoBehaviour
{
    public HealthUIController healthController;

    public GameObject gameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
