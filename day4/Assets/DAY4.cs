using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DAY4 : MonoBehaviour
{
    public int Score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

     public void scoreUp()
    {
        Score += 1;
        scoreText.text = Score.ToString();
    }   
}



