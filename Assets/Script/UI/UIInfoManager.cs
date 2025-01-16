using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIInfoManager : MonoBehaviour
{
    [Header("Game Start panel")]
    [Header("Buttons")]

    [SerializeField] private Button BackButton;
   

    [Header("Scene Names")]
    [SerializeField] private string PlayLevelName;

    [Header("SoundManager")]
    [SerializeField] private GameSoundManager soundManager; 

    // Start is called before the first frame update
    void Start()
    {
        BackButton.onClick.AddListener(PlayGame);
  
    }


    void PlayGame()
    {
        soundManager.PlayButtonClickAudio();
        SceneManager.LoadScene(PlayLevelName);
    }

   
}
