using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMerger : MonoBehaviour
{
    public Transform Purple;
    public Transform Green;
    public Transform Blue;
    public Transform Red;
    

    private void Start()
    {
        Purple.GetComponent<Transform>();
        Green.GetComponent<Transform>();
        Red.GetComponent<Transform>();
        Blue.GetComponent<Transform>();
    }
    void Merge()
    {
        Purple.position = new Vector2(-1.6413f, 0f);
        Purple.rotation = Quaternion.Euler(0, 0, 0);
        Green.position = new Vector2(-1.6413f, -1.7292f);
        Green.rotation = Quaternion.Euler(0, 0, 90);
        Red.position = new Vector2(0f, -1.7292f);
        Red.rotation = Quaternion.Euler(0, 0, -180);
        Blue.position = new Vector2(0f, 0f);
        Blue.rotation = Quaternion.Euler(0, 0, -90);
    }
   
}
