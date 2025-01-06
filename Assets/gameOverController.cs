using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverController : MonoBehaviour
{
    public PlantController plantController;

    public HealthController healthController;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plantController.Plant.Count <1)
        {
            gameOverPanel.SetActive(true);
        }

        if (healthController.healthBar.Count <1)
        {
            gameOverPanel.SetActive(true);
        }
    }

    

}
