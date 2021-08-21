using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameOverScript gameOver;
    int finalScore;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObj = collision.gameObject;

        if (hitObj.tag == "Player")
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        finalScore = Scoring.theScore;
        gameOver.Setup(finalScore);
    }
}
