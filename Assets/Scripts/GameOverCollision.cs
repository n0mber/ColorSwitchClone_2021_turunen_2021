using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollision : MonoBehaviour
{
    //public GameObject playerDot;
    
    public GameObject arcColor; //get obstacle - script's object
    public ColorChange colorChange; //get player color from ColorChange script
    public EndGame endGame; //get end game and game over screen from EndGame script
    public AudioSource defeatSound; //get cound

   
    //When player hits wrong colored obstacle, game over
    void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.tag == "Player")
        {
            //if obstacles tag is not same than player's current color, end game
            if (arcColor.gameObject.tag != colorChange.currentColor) 
            {
                defeatSound.Play();
                Destroy(collision.gameObject);
                endGame.GameOver();
                
            }
        }
    }
}
