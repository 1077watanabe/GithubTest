using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        life = 3;
        textGameOver.enabled = false;
        score = 0;
        textScore = GameObject.Find("Score").GetComponent<Text>();
        textLife = GameObject.Find("BallLife").GetComponent<Text>();
        SetScoreText(score);
        SetLifeText(life);
        inGame = true;
    }

    private void SetScoreText(int score) 
    {
        textScore.text = "Score :" + score.ToString();
    }

    public void AddScore(int point) 
    {
        score += point; SetScoreText(score); 
    }

    private void SetLifeText(int life)
    {
        textLife.text = "Ball :" + life.ToString();
    }

    // Update is called once per frame
    public GameObject ballPrefab;
    public int life;
    public Text textGameOver;
    private int score;
    private Text textScore;
    private Text textLife; private bool inGame;
    void Update()
    {
        if (inGame)
        {
            GameObject ballObj = GameObject.Find("Ball");

            if (ballObj == null)
            {
                --life;
                if (life > 0)
                {
                    GameObject newBall = Instantiate(ballPrefab);
                    newBall.name = ballPrefab.name;
                }
                else
                {
                    life = 0;
                    textGameOver.enabled = true;
                    inGame = false;
                }
            }
        }
        
    }
}
 
    

