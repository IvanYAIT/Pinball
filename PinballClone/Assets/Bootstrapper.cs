using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Rigidbody rightFipperRb;
    [SerializeField] private Rigidbody leftFipperRb;
    [SerializeField] private GameObject spring;
    [SerializeField] private InputListener inputListener;
    [SerializeField] private int ballAmount;
    [SerializeField] private ScoreView scoreView;
    [SerializeField] private Ball ball;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private int pointsPerObstacel;
    [SerializeField] private TextMeshProUGUI ballText;

    private ScoreCounter scoreCounter;
    private BallSpawner ballSpawner;

    void Start()
    {
        ballSpawner = new BallSpawner(spawnPoint, ballPrefab, ballAmount, ballText);
        scoreCounter = new ScoreCounter(scoreView);
        ball.Construct(scoreCounter, ballSpawner, pointsPerObstacel);
        inputListener.Construct(rightFipperRb, leftFipperRb, spring);
    }

    void Update()
    {
        
    }
}
