using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour
{
    private GameObject _spring;
    private SpringJoint _springJoint;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
            if (_springJoint.minDistance <= 4)
                _springJoint.minDistance += 0.05f;

        if (Input.GetKeyUp(KeyCode.Space))
            _springJoint.minDistance = 0;

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }

    public void Construct(GameObject spring)
    {
        _spring = spring;
        _springJoint = _spring.GetComponent<SpringJoint>();
    }
}
