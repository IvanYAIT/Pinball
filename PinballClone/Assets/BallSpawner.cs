using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallSpawner
{
    private GameObject _spawnPoint;
    private GameObject _ballPrefab;
    private int _ballAmount;
    private TextMeshProUGUI _ballText;

    public static Action OnNotEnoughBalls;

    public BallSpawner(GameObject spawnPoint, GameObject ballPrefab, int ballAmount, TextMeshProUGUI ballText)
    {
        _spawnPoint = spawnPoint;
        _ballPrefab = ballPrefab;
        _ballAmount = ballAmount;
        _ballText = ballText;
        _ballText.text = $"Balls: {_ballAmount}";
    }

    public GameObject Spawn()
    {
        if(_ballAmount > 0)
        {
            _ballAmount--;
            _ballText.text = $"Balls: {_ballAmount}";
            return GameObject.Instantiate(_ballPrefab, _spawnPoint.transform.position, Quaternion.identity);
        }
        else
        {
            OnNotEnoughBalls?.Invoke();
            return null;
        }
    }
}
