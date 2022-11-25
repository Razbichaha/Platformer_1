using System.Collections;
using UnityEngine;

public class NPS : MonoBehaviour
{
    [SerializeField] private int _directionMovement = 1;
    public int _speed = 5;
    public int _stopRigidbodyTime = 2;
    private Transform _locationObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _directionMovement = _directionMovement * -1;
        StartCoroutine(SpawnNps());
    }

    private void Start()
    {
        _locationObject = gameObject.transform;
    }

    private void Update()
    {
        MovingToPoint();
    }

    private void MovingToPoint()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMovement, 0, 0);
    }

    IEnumerator SpawnNps()
    {
        gameObject.GetComponent<Rigidbody2D>().simulated = false;
            yield return new WaitForSeconds(_stopRigidbodyTime);
        gameObject.GetComponent<Rigidbody2D>().simulated = true;
    }
}
