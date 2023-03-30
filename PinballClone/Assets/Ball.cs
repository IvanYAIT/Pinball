using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreCounter _scoreCounter;
    private BallSpawner _ballSpawner;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            GameObject obj = _ballSpawner.Spawn();
            obj.GetComponent<Ball>().Construct(_scoreCounter, _ballSpawner);
        }
    }

    public void Construct(ScoreCounter scoreCounter, BallSpawner ballSpawner)
    {
        _scoreCounter = scoreCounter;
        _ballSpawner = ballSpawner;
    }
}
