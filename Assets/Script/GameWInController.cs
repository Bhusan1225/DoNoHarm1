using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWInController : MonoBehaviour
{
    public HealthController healthController;

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
            gameWinPanel.SetActive(true);
        }
    }
}
