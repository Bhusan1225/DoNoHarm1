using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [Header("Game Over panel")]
    [Header("Buttons")]

    [SerializeField] private Button RetryButton;
    [SerializeField] private Button QuitButton;

    [Header("Scene Names")]
    [SerializeField] private string RetryLevelName;
    [SerializeField] private string QuitLevelName;

    [Header("Winning UI panel")]
    [Header("Buttons")]

    [SerializeField] private Button WinRetryButton;
    [SerializeField] private Button WinQuitButton;

    [Header("SoundManager")]
    [SerializeField] private GameSoundManager soundManager;



    // Start is called before the first frame update
    void Start()
    {
        RetryButton.onClick.AddListener(RetryGame);
        QuitButton.onClick.AddListener(GoMainMenu);

        WinRetryButton.onClick.AddListener(RetryGame);
        WinQuitButton.onClick.AddListener(GoMainMenu);


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
