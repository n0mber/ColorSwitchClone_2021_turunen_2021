using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPoints : MonoBehaviour
{
    public GameObject[] transport;
    int current = 0;
    float rotSpeed;
    public float speed;
    float TransRadius = 1;
    public Renderer rend;
    int currentIndex = 0;


    public List<Color> colorList = new List<Color> { new Color(184f/255f, 0f/255f, 228f/255f),
                                                     new Color(41f/255f, 222f/255f, 0f/255f),
                                                     new Color(0f/255f, 101f/255f, 255f/255f),
                                                     new Color(255f/255f, 62f/255f, 57f/255f) };

    // Update is called once per frame

    void Start()
    {
        rend.material.color = colorList[currentIndex];
    }

    void Update()
    {
       if (Vector2.Distance(transport[current].transform.position, transform.position) < TransRadius)
        {
            current++;
            if (current >= transport.Length)
            {
                current = 0;

                currentIndex += 1;
                if (currentIndex >= colorList.Count)
                    currentIndex = 0;

                rend.material.color = colorList[currentIndex];
                
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, transport[current].transform.position, Time.deltaTime * speed);

    }

}
