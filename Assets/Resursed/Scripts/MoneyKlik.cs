using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyKlik : MonoBehaviour
{
    private static float _pauseTime = 2f;
    private const string AnimationDeadShpera = "deadSphera";

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

    WaitForSeconds _wait = new WaitForSeconds(_pauseTime);

   private IEnumerator SpherosDelete()
    {
        yield return _wait;
        _objectUnActivate.SetActive(false);
    }

}
