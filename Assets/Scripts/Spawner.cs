using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    static private int _pauseTime = 2;
    private int _numberOfObject = 2;

    [SerializeField] private NPS _nps;

    private void Start()
    {
        StartCoroutine(SpawnNps());
    }

    WaitForSeconds _wait = new WaitForSeconds(_pauseTime);

    IEnumerator SpawnNps()
    {
        for (int i = 0; i < _numberOfObject; i++)
        {
            Instantiate(_nps, gameObject.transform.position, gameObject.transform.localRotation);
            yield return _wait;
        }
    }
}
