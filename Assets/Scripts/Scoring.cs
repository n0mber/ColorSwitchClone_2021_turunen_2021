using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    //collect WhiteStars and change score

    public GameObject scoreText;
    public static int theScore;

    private void Awake()
    {
        theScore = 0;
    }

    void Update()
    {
        //set new score to UI
        scoreText.GetComponent<TextMeshProUGUI>().text = "" + theScore;
    }



}
