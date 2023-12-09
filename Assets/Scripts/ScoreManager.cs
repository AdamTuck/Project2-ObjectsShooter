using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public UnityEvent OnScoreUpdated;

    public int GetScore()
    {
        return score;
    }

    public void IncrementScore(int value)
    {
        score += value;
        OnScoreUpdated?.Invoke();
    }
}