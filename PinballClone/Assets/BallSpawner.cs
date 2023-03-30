using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner
{
    private GameObject _spawnPoint;
    private GameObject _ballPrefab;
    private int _ballAmount;

    public BallSpawner(GameObject spawnPoint, GameObject ballPrefab, int ballAmount)
    {
        _spawnPoint = spawnPoint;
        _ballPrefab = ballPrefab;
        _ballAmount = ballAmount;
    }

    public GameObject Spawn()
    {
        if(_ballAmount > 0)
        {
            _ballAmount--;
            return Object.Instantiate(_ballPrefab, _spawnPoint.transform.position, Quaternion.identity);
        }
        else
            return null;
    }
}
