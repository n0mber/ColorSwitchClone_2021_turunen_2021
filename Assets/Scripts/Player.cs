using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidbody2D;
    private float jumpForce = 200f;


    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    
   
    private void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            myRigidbody2D.AddForce(Vector2.up * jumpForce);

        }
    }
}
