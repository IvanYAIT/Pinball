using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 heading = transform.position - collision.gameObject.transform.position;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance;
        }
    }
}
