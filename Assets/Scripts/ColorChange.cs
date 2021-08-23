using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//When collided with ColorSwitcher, change PlayerDot's color
public class ColorChange : MonoBehaviour
{
    public GameObject playerDot;
    public Renderer rend; //playerDot's sprite renderer
    public string currentColor;
    public int currentIndex = 5;



    public List<Color> colorList = new List<Color> { new Color(184f/255f, 0f/255f, 228f/255f),
                                                     new Color(41f/255f, 222f/255f, 0f/255f),
                                                     new Color(0f/255f, 101f/255f, 255f/255f),
                                                     new Color(255f/255f, 62f/255f, 57f/255f) };

    void Start()
    {
        rend.GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Choose random color from colorList to be set as PlayerDot's color
        int itemIndex = Random.Range(0, 4);

        //if random itemIndex is same that currentIndex, get new random itemIndex
        while (itemIndex == currentIndex)
        {
            itemIndex = Random.Range(0, 4);
        }

        // set new color for the playerDot
        rend.material.color = colorList[itemIndex];

        //set currentColor and currentIndex value based on the itemIndex value
        if (itemIndex == 0)
        {
            currentColor = "Magenta";
            currentIndex = itemIndex;
        }

        if (itemIndex == 1)
        { 
            currentColor = "Green";
            currentIndex = itemIndex;
        }

        if (itemIndex == 2)
        { 
            currentColor = "Blue";
            currentIndex = itemIndex;
        }

        if (itemIndex == 3)
        {
            currentColor = "Red";
            currentIndex = itemIndex;
        }


        //Destroy after 
        Destroy(gameObject);
    }
    
    
}
