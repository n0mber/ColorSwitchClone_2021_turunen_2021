using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   
    public GameObject changeColor;
    public Renderer rend;
    public Color red = Color.red;
    public Color green = Color.green;
    public Color blue = Color.blue;
    public Color magenta = Color.magenta;

    public List<Color> colorList = new List<Color> {Color.red, Color.green, Color.blue, Color.magenta};

     void Start()
    {
        rend.GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        int itemIndex = Random.Range(0, 4);
        rend.material.color = colorList[itemIndex];
           
    }
    
    
}
