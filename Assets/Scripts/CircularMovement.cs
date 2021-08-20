using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    //speed for rotation
    public float rotationSpeed = 100f;

     void Update()
    {
        //set rotate
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }


}
