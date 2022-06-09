using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;

    public BallController ball;

    public void AddRightScore(int increement)
    {
        rightScore += increement;
        ball.ResetBall();
        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increement)
    {
        leftScore += increement;
        ball.ResetBall();
        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
