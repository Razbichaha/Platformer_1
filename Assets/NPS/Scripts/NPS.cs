using System.Collections;
using UnityEngine;

public class NPS : MonoBehaviour
{
    static private int _stopRigidbodyTime = 2;
    private int _directionMovement = 1;
    private int _speed = 1;

    private WaitForSeconds _wait = new WaitForSeconds(_stopRigidbodyTime);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _directionMovement = _directionMovement * -1;

        StartCoroutine(SimulatedNpsStop());
    }

    private void Update()
    {
        MovingToPoint();
    }

    private void MovingToPoint()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMovement, 0, 0);
    }

    private IEnumerator SimulatedNpsStop()
    {
        var component = gameObject.GetComponent<Rigidbody2D>();

        component.simulated = false;
        yield return _wait;
        component.simulated = true;
    }
}
