using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int cost;

    private GameObject _currentPoint;

    public void SetCurrentPoint(GameObject currentPoint)
    {
        _currentPoint = currentPoint;
        currentPoint.SetActive(false);
    }

    private void OnDestroy()
    {
        _currentPoint.SetActive(true);
    }
}
