using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text HighScoreText;
    [SerializeField] private Text ScoreText;

    public float score;
    public int highscore;

    void Start()
    {
        score = 0;
    }
    
    void Update()
    {
        highscore = (int)score;
        ScoreText.text = "SCORE: " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
        }
            
        HighScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("score").ToString();
    }
}