using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]


public class StartMenuUIControl : MonoBehaviour
{
    public Text scoreText;
    public InputField nameField;
    void Awake()
    {
        if (GeneralManager.Instance != null) {
            GeneralManager.Instance.LoadHS();
            int scoreToShow = GeneralManager.Instance.highScore;
            string nameToShow = GeneralManager.Instance.playerName;
            
            scoreText.text = "High score: "+ nameToShow +": "+ scoreToShow;

        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNewGame()
    {
        GeneralManager.Instance.currentName = nameField.text;
        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
      Application.Quit();
    #endif
    }

}
