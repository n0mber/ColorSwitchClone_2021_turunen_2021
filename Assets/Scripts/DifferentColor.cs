using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentColor : MonoBehaviour
{
    public Collider2D playerDot; //player Collider
    public Renderer rend; //player Sprite renderer
    public Renderer Magenta; //Circle arc
    public Renderer Green; //Circle arc
    public Renderer Blue; //Circle arc
    public Renderer Red;  //Circle arc
    public GameObject player;
    

    //colors for player sprite

    public Color red = Color.red;
    public Color green = Color.green;
    public Color blue = Color.blue;
    public Color magenta = Color.magenta;

    public EndGame endGame;

    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
        Magenta.GetComponent<Renderer>();
        Green.GetComponent<Renderer>();
        Blue.GetComponent<Renderer>();
        Red.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void OnCollisionEnter2D (Collision col)
    {
        //If PlayerDot color is set, ignore collision between dot and same colored arc
        if ((rend.material.color != Red.material.color) && (col.gameObject.tag == "Player")) { /*Red.GetComponent<PolygonCollider2D>();*/ Destroy(col.gameObject); endGame.GameOver(); };
        if ((rend.material.color != Green.material.color) && (col.gameObject.tag == "Player")) { /*Green.GetComponent<PolygonCollider2D>();*/ Destroy(col.gameObject); endGame.GameOver(); };
        if ((rend.material.color != Blue.material.color) && (col.gameObject.tag == "Player")) { /*Blue.GetComponent<PolygonCollider2D>();*/ Destroy(col.gameObject); endGame.GameOver(); };
        if ((rend.material.color != Magenta.material.color) && (col.gameObject.tag == "Player")){ /*Magenta.GetComponent<PolygonCollider2D>();*/ Destroy(col.gameObject); endGame.GameOver(); };
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(player); 
        endGame.GameOver();
    }*/
}
