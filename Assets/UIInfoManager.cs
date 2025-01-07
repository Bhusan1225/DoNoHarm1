using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIInfoManager : MonoBehaviour
{
    [Header("Game Start panel")]
    [Header("Buttons")]

    public Button BackButton;
   

    [Header("Scene Names")]
    public string PlayLevelName;
    


    // Start is called before the first frame update
    void Start()
    {
        BackButton.onClick.AddListener(PlayGame);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayGame()
    {
        SceneManager.LoadScene(PlayLevelName);
    }

   
}
