using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyKlik : MonoBehaviour
{
    private const string AnimationDeadShpera = "deadSphera";
    private float _pauseTime = 2f;

    [SerializeField] private GameObject _score;
    [SerializeField] private GameObject _objectUnActivate;
    [SerializeField] private Animator _speraDead;

    private void Start()
    {
        _score.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AnimationDeadSpera();
    }

    private void AnimationDeadSpera()
    {
        _speraDead.SetBool(AnimationDeadShpera, true);
        _score.SetActive(true);
        StartCoroutine(SpherosDelete());
    }

    IEnumerator SpherosDelete()
    {
        yield return new WaitForSeconds(_pauseTime);
        _objectUnActivate.SetActive(false);
    }

}
