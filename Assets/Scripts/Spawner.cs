using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private NPS _nps;

    private int _numberOfObject=2;
    private int _pauseTime = 2;

    private void Start()
    {
       StartCoroutine(SpawnNps());
    }

    IEnumerator SpawnNps()
    {
        for (int i = 0; i < _numberOfObject; i++)
        {
            Instantiate(_nps,gameObject.transform.position,gameObject.transform.localRotation);
            yield return new WaitForSeconds(_pauseTime);
        }
    }
}
