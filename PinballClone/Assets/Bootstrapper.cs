using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Rigidbody rightFipperRb;
    [SerializeField] private Rigidbody leftFipperRb;
    [SerializeField] private GameObject spring;
    [SerializeField] private InputListener inputListener;

    void Start()
    {
        inputListener.Construct(rightFipperRb, leftFipperRb, spring);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
