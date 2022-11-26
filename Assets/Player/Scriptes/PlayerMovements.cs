using UnityEngine.Events;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float _jampPower = 5;
    private float _speed = 2;
    private float _speedRun = 4;
    private bool _thereIsMovement = false;

    private Quaternion _stopRotation = new Quaternion(0, 0, 0, 0);

    [SerializeField] private UnityEvent _walkLeft;
    [SerializeField] private UnityEvent _walkRight;
    [SerializeField] private UnityEvent _walkStop;
    [SerializeField] private UnityEvent _RunStart;
    [SerializeField] private UnityEvent _RunStop;

    private void Update()
    {
        gameObject.transform.rotation = _stopRotation;

        if (Input.GetKey(KeyCode.A))
        {
            _walkLeft.Invoke();
            gameObject.transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _thereIsMovement = true;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            _walkStop.Invoke();
            _thereIsMovement = false;
            _RunStop.Invoke();
            _speed = 2;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _walkRight.Invoke();
            gameObject.transform.Translate(_speed * Time.deltaTime, 0, 0);
            _thereIsMovement = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            _walkStop.Invoke();
            _thereIsMovement = false;
            _RunStop.Invoke();
            _speed = 2;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(0, _speed * Time.deltaTime * _jampPower, 0);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _RunStop.Invoke();
            _speed = 2;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (_thereIsMovement)
            {
                _RunStart.Invoke();
                _speed = _speedRun;
            }
        }
    }
}
