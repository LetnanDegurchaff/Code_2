using System.Collections;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private GameObject _copyingObject;

    private SpawnPoint[] _points;

    private void Start()
    {
        _points = GetComponentsInChildren<SpawnPoint>();
        Coroutine spawnProcces = StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        while (true)
        {
            for (int i = 0; i < _points.Length; i++)
            {
                _points[i].CreateObject(_copyingObject);
                Debug.Log($"Создался объект из спавнера {i}");

                yield return new WaitForSeconds(2f);
            }
        }
    }
}
