using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    //Active Game over screen and set final score text
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + "";
    }

    //Restart button loads game from beginning
    public void RestartButton()
    {
        SceneManager.LoadScene("ColorSwitchCloneGAME"); 

    }

    //Quit application
    public void QuitButton()
    {
        Application.Quit();
    }

}
