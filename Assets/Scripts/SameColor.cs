using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SameColor : MonoBehaviour
{
    //Player dot gets throught same colored obstacle

    public Collider2D playerDot; //player Collider
    public Renderer rend; //player Sprite renderer
    public GameObject Magenta; //Circle arc
    public GameObject Green; //Circle arc
    public GameObject Blue; //Circle arc
    public GameObject Red;  //Circle arc

    //colors for player sprite

    public Color red = Color.red;
    public Color green = Color.green;
    public Color blue = Color.blue;
    public Color magenta = Color.magenta;

    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //If PlayerDot color is set, ignore collision between dot and same colored arc
        if (rend.material.color == Color.red) { Physics2D.IgnoreCollision(playerDot.GetComponent<Collider2D>(), Red.GetComponent<Collider2D>()); };
        if (rend.material.color == Color.green) { Physics2D.IgnoreCollision(playerDot.GetComponent<Collider2D>(), Green.GetComponent<Collider2D>()); };
        if (rend.material.color == Color.blue) { Physics2D.IgnoreCollision(playerDot.GetComponent<Collider2D>(), Blue.GetComponent<Collider2D>()); };
        if (rend.material.color == Color.magenta) { Physics2D.IgnoreCollision(playerDot.GetComponent<Collider2D>(), Magenta.GetComponent<Collider2D>()); };
    }
}
