using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResumeController : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GamePause_Resume();
        }
    }

    void GamePause_Resume()
    {
        //isPaused = !isPaused;
        if(isPaused == false)
        {
            isPaused = true;
        }else if (isPaused == true)
        {
            isPaused = false;
        }



        if (isPaused)
        {
            Time.timeScale = 0f; // Pause

        }
        else
        {
            Time.timeScale = 1f; // Resume 

        }
    }

}