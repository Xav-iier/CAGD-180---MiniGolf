using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public int score = 0;
    //public Text scoreText;

    public void AddScore()
    {
        score++;
       // UpdateScoreUI();
    }

   // void UpdateScoreUI()
 //   {
       // if (scoreText != null)
         //   scoreText.text = "Score: " + score;
  //  }
}
