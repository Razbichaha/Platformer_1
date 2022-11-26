using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public int _speed = 1;

    [SerializeField] private int _directionMovement = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _directionMovement=_directionMovement * -1;
    }

    private void Update()
    {
        MovingToPoint();
    }

    private void MovingToPoint()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMovement, 0, 0);
    }
}
