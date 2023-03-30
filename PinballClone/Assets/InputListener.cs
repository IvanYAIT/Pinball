using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour
{
    private Rigidbody _rightFipperRb;
    private Rigidbody _leftFipperRb;
    private GameObject _spring;
    private SpringJoint _springJoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            _leftFipperRb.AddForce(400, 0, 0, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.X))
            _rightFipperRb.AddForce(-400, 0, 0, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.Space))
            if (_springJoint.minDistance <= 4)
                _springJoint.minDistance += 0.05f;

        if (Input.GetKeyUp(KeyCode.Space))
            _springJoint.minDistance = 0;

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }

    public void Construct(Rigidbody rightFipperRb, Rigidbody leftFipperRb, GameObject spring)
    {
        _rightFipperRb = rightFipperRb;
        _leftFipperRb = leftFipperRb;
        _spring = spring;
        _springJoint = _spring.GetComponent<SpringJoint>();
    }
}
