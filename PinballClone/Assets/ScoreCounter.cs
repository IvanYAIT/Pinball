using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter
{
    private int _score;
    private ScoreView _scoreView;

    public void AddScore(int score)
    {
        _score += score;
        _scoreView.View(_score);
    }

    public ScoreCounter(ScoreView scoreView)
    {
        _scoreView = scoreView;
    }
}
