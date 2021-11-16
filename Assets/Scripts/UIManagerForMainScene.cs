using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerForMainScene : MonoBehaviour
{
    public GameObject mainManager;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        string nameToShow = GeneralManager.Instance.playerName;
        int scoreToShow = GeneralManager.Instance.highScore;
        highScoreText.text = "Best Score: " + nameToShow + ": " + scoreToShow;
    }


    public void ReturnToMenu()
    {
       
        SceneManager.LoadScene(0);

    }
  

}
