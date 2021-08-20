using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   //When collided with ColorSwitcher, change PlayerDot's color

    public GameObject playerDot;
    public Renderer rend;

    //colors for PlayerDot
    public Color red = Color.red;
    public Color green = Color.green;
    public Color blue = Color.blue;
    public Color magenta = Color.magenta;

    //List of colors
    public List<Color> colorList = new List<Color> {Color.red, Color.green, Color.blue, Color.magenta};

    void Start()
    {
        rend.GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Choose random color from colorList to be set as PlayerDot's color
        int itemIndex = Random.Range(0, 4);
        rend.material.color = colorList[itemIndex];

        //Destroy after collision
        Destroy(gameObject);

    }
    
    
}
