using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    //collect WhiteStars and change score

    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter2D (Collider2D other)
    {
        //change score by one
        theScore ++;

        //set new score to UI
        scoreText.GetComponent<Text>().text = theScore.ToString();

        //once collected, play sound and destroy object
        collectSound.Play();
        Destroy(gameObject);

    }



}
