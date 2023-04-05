using UnityEngine;

public class Ball : MonoBehaviour
{
    private ScoreCounter _scoreCounter;
    private BallSpawner _ballSpawner;
    private int _pointsPerObstacel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacel"))
        {
            _scoreCounter.AddScore(_pointsPerObstacel);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            GameObject obj = _ballSpawner.Spawn();
            obj.GetComponent<Ball>().Construct(_scoreCounter, _ballSpawner, _pointsPerObstacel);
        }
        if (other.CompareTag("Bonus"))
        {
            _scoreCounter.AddScore(other.gameObject.GetComponent<Bonus>().cost);
            Destroy(other.gameObject);
        }
    }

    public void Construct(ScoreCounter scoreCounter, BallSpawner ballSpawner, int pointsPerObstacel)
    {
        _scoreCounter = scoreCounter;
        _ballSpawner = ballSpawner;
        _pointsPerObstacel = pointsPerObstacel;
    }
}
