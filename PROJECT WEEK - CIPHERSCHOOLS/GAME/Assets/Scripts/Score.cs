using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highscoreText;

    int currScore;
    int highscore;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        highscoreText.text = highscore.ToString();
    }
    private void Update()
    {
        currScore = Mathf.FloorToInt(player.position.z);
        scoreText.text = currScore.ToString();

        if(currScore > highscore){
            highscore = currScore;
            highscoreText.text = highscore.ToString();
            PlayerPrefs.SetInt("highscore", currScore);
        }
    }
}