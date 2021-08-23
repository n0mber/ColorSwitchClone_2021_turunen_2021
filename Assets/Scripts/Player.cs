using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidbody2D;
    private float jumpForce = 150f; //Force for the jump
    


    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
   
    private void Update()
    {
        //make PlayerDot jump when Left Mouse Button is down
        if (Input.GetMouseButtonDown (0))
        {
            
            myRigidbody2D.AddForce(Vector2.up * jumpForce);

        }
    }

    void OnDestroy()
    {
        transform.parent.gameObject.AddComponent<GameOverScript>();
    }
}
