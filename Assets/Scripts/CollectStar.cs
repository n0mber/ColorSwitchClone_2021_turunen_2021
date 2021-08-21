using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        //change score by one
        Scoring.theScore += 1;

        //once collected, play sound and destroy object
        collectSound.Play();
        Destroy(gameObject);

    }
}
