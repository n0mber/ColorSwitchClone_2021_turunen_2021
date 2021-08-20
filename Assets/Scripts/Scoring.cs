using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter2D (Collider2D other)
    {
        Destroy(gameObject);
        collectSound.Play();
        theScore ++;
        scoreText.GetComponent<Text>().text = theScore.ToString();
        


        
    }



}
