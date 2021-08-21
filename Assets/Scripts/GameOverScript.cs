using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + "";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("ColorSwitchCloneGAME");

    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
