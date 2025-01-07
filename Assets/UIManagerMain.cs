using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerMain : MonoBehaviour
{
    [Header("Game Start panel")]
    [Header("Buttons")]

    public Button PlayButton;
    public Button InfoButton;

    [Header("Scene Names")]
    public string PlayLevelName;
    public string InfoLevelName;


    [Header("SoundManager")]
    public SoundManager soundManager;




    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        InfoButton.onClick.AddListener(GoToInfo);



    }

    // Update is called once per frame
    void Update()
    {

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
