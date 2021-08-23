using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPoints : MonoBehaviour
{
    public GameObject[] transport; //Array of movement points
    int current = 0;
    public float speed;
    float TransRadius = 1;
    public Renderer rend; //obstacle's sprite renderer
    int currentIndex = 0;

    //colors that obsctacle have
    public List<Color> colorList = new List<Color> { new Color(184f/255f, 0f/255f, 228f/255f),
                                                     new Color(41f/255f, 222f/255f, 0f/255f),
                                                     new Color(0f/255f, 101f/255f, 255f/255f),
                                                     new Color(255f/255f, 62f/255f, 57f/255f) };

    //color's tags for obstacle's gameobject tag
    public List<string> tags = new List<string> { "Magenta", "Green", "Blue", "Red" };
    

    void Start()
    {
        //set obstacles first color, index 0 = Magenta
        rend.material.color = colorList[currentIndex];
    }

    void Update()
    {
       if (Vector2.Distance(transport[current].transform.position, transform.position) < TransRadius) //start from first movement point, index 0
        {
            current++; //add 1 to transpoint index

            //when all transpoints are done, begin from zero
            if (current >= transport.Length)
            {
                current = 0;

                //get next color from the list
                currentIndex += 1;

                //at the end of color list, begin again from zero
                if (currentIndex >= colorList.Count)
                    currentIndex = 0;

                
                rend.material.color = colorList[currentIndex]; //change obstacle color
                rend.gameObject.tag = tags[currentIndex]; //change tag


            }
        }

        transform.position = Vector2.MoveTowards(transform.position, transport[current].transform.position, Time.deltaTime * speed); //move gameobject to next movement point

    }

}
