using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [Header("Game Over panel")]
    [Header("Buttons")]

    public Button RetryButton;
    public Button QuitButton;

    [Header("Scene Names")]
    public string RetryLevelName;
    public string QuitLevelName;

    [Header("Winning UI panel")]
    [Header("Buttons")]

    public Button WinRetryButton;
    public Button WinQuitButton;

    [Header("SoundManager")]
    public SoundManager soundManager;



    // Start is called before the first frame update
    void Start()
    {
        RetryButton.onClick.AddListener(RetryGame);
        QuitButton.onClick.AddListener(GoMainMenu);

        WinRetryButton.onClick.AddListener(RetryGame);
        WinQuitButton.onClick.AddListener(GoMainMenu);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RetryGame()
    {
        soundManager.PlayButtonClickAudio();
        SceneManager.LoadScene(RetryLevelName);
    }

    void GoMainMenu()
    {
        soundManager.PlayButtonClickAudio();
        SceneManager.LoadScene(QuitLevelName);
    }
}
