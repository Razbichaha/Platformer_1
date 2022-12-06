using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private NPS _nps;

    private const int Delay = 2;

    private int _numberOfObject = 2;

    private WaitForSeconds _wait = new WaitForSeconds(Delay);

    private void Start()
    {
        StartCoroutine(GenerationNps());
    }

    private IEnumerator GenerationNps()
    {
        for (int i = 0; i < _numberOfObject; i++)
        {
            Instantiate(_nps, gameObject.transform.position, gameObject.transform.localRotation);
            yield return _wait;
        }
    }
}
