using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Score : MonoBehaviour
{

    private float score = 0.0f;

    public TextMeshProUGUI scoreText;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;
                              
    void Start()
    {
        
    }

    void Update()
    {
        if (score >= scoreToNextLevel)
            LevelUp();

        score += Time.deltaTime * difficultyLevel;
        scoreText.text = ((int)score).ToString();

        Debug.Log(difficultyLevel);
    }
    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;
        
        scoreToNextLevel *= 2;
        difficultyLevel++;

        GetComponent<Player>().SetSpeed(difficultyLevel);

        

    }

   
}
