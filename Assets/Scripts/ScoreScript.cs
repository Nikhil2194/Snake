using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    Text winScore;


    private void Awake()
    {
        score = GetComponent<Text>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        score.text = "Score : " + scoreValue;
        
    }



    /*private void win()
    {
        if (scoreValue >= 5)
        {
            winScore.text = "Congarts you are now snake king";
        }
       
    }*/
}


