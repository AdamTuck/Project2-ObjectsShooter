using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int score, highScore;

    public UnityEvent OnScoreUpdated, OnHighScoreUpdated;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        highScore = PlayerPrefs.GetInt("HighScore");
        OnHighScoreUpdated?.Invoke();
        GameManager.GetInstance().OnGameStart += OnGameStart;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHighScore ()
    {
        return highScore;
    }

    public void IncrementScore(int value)
    {
        score += value;
        OnScoreUpdated?.Invoke();

        if (score > highScore)
        {
            highScore = score;
            OnHighScoreUpdated?.Invoke();
        }
    }

    public void SetHighScore ()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public void OnGameStart()
    {
        score = 0;
    }
}