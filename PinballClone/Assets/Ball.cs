using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreCounter _scoreCounter;
    private BallSpawner _ballSpawner;
    private int _pointsPerObstacel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacel"))
        {
            _scoreCounter.AddScore(_pointsPerObstacel);
        }
        if (collision.gameObject.CompareTag("Bonus"))
        {
            _scoreCounter.AddScore(collision.gameObject.GetComponent<Bonus>().cost);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            GameObject obj = _ballSpawner.Spawn();
            obj.GetComponent<Ball>().Construct(_scoreCounter, _ballSpawner, _pointsPerObstacel);
        }
    }

    public void Construct(ScoreCounter scoreCounter, BallSpawner ballSpawner, int pointsPerObstacel)
    {
        _scoreCounter = scoreCounter;
        _ballSpawner = ballSpawner;
        _pointsPerObstacel = pointsPerObstacel;
    }
}
