using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerMainMenu : MonoBehaviour
{
    [Header("Game Start panel")]
    [Header("Buttons")]

    [SerializeField] private Button PlayButton;
    [SerializeField] private Button InfoButton;

    [Header("Scene Names")]
    [SerializeField] private string PlayLevelName;
    [SerializeField] private string InfoLevelName;


    [Header("SoundManager")]
    [SerializeField] private GameSoundManager soundManager;




    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        InfoButton.onClick.AddListener(GoToInfo);

    }

  
    void PlayGame()
    {
        soundManager.PlayButtonClickAudio();
        SceneManager.LoadScene(PlayLevelName);
    }

    void GoToInfo()
    {
        soundManager.PlayButtonClickAudio();
        SceneManager.LoadScene(InfoLevelName);
    }
}
