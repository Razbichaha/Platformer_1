using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const int _delay = 2;

    private int _numberOfObject = 2;

    [SerializeField] private NPS _nps;

    private void Start()
    {
        StartCoroutine(SpawnNps());
    }

    WaitForSeconds _wait = new WaitForSeconds(_delay);

  private  IEnumerator SpawnNps()
    {
        for (int i = 0; i < _numberOfObject; i++)
        {
            Instantiate(_nps, gameObject.transform.position, gameObject.transform.localRotation);
            yield return _wait;
        }
    }
}
