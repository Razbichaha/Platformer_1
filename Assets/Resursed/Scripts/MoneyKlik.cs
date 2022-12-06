using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyKlik : MonoBehaviour
{
    [SerializeField] private GameObject _score;
    [SerializeField] private GameObject _objectUnActivate;
    [SerializeField] private Animator _speraDead;

    private static float _pauseTime = 2f;
    private const string AnimationDeadShpera = "deadSphera";

    private WaitForSeconds _wait = new WaitForSeconds(_pauseTime);

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

    private IEnumerator SpherosDelete()
    {
        yield return _wait;
        _objectUnActivate.SetActive(false);
    }
}
