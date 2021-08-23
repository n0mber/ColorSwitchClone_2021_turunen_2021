using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollision : MonoBehaviour
{
    //public GameObject playerDot;
    
    public GameObject arcColor;
    public ColorChange colorChange;
    public EndGame endGame;

    void Start()
    {  
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.tag == "Player")
        {
            if (arcColor.gameObject.tag != colorChange.currentColor)
            { 
                Destroy(collision.gameObject);
                endGame.GameOver();
                
            }
        }
    }
}
