using System.Collections;
using System.Collections.Generic;
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

    private ScoreCounter scoreCounter;
    private BallSpawner ballSpawner;

    void Start()
    {
        ballSpawner = new BallSpawner(spawnPoint, ballPrefab, ballAmount);
        scoreCounter = new ScoreCounter(scoreView);
        ball.Construct(scoreCounter, ballSpawner);
        inputListener.Construct(rightFipperRb, leftFipperRb, spring);
    }

    void Update()
    {
        
    }
}
