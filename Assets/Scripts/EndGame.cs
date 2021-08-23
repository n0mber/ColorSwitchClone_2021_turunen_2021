using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndGame : MonoBehaviour
{
    public GameOverScript gameOver;
    int finalScore;
    public AudioSource endSound;

    //When player hits obstacle or finish line, play sound and destroy player
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject hitObj = collision.gameObject;

        if (hitObj.tag == "Player")
        {
            endSound.Play();
            Destroy(collision.gameObject);
            GameOver(); //get game over screen
        }
    }

    //Get final score and send it to Game over screen
    public void GameOver()
    {
        finalScore = Scoring.theScore;
        gameOver.Setup(finalScore); //GameOverScript
    }
}
