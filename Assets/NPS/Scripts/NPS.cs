using System.Collections;
using UnityEngine;

public class NPS : MonoBehaviour
{
    static private int _stopRigidbodyTime = 2;
    private int _directionMovement = 1;
    private int _speed = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _directionMovement = _directionMovement * -1;

        StartCoroutine(SpawnNps());
    }
    
    private void Update()
    {
        MovingToPoint();
    }

    private void MovingToPoint()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMovement, 0, 0);
    }

    WaitForSeconds _wait = new WaitForSeconds(_stopRigidbodyTime);

   private IEnumerator SpawnNps()
    {
        gameObject.GetComponent<Rigidbody2D>().simulated = false;
        yield return _wait;
        gameObject.GetComponent<Rigidbody2D>().simulated = true;
    }
}
