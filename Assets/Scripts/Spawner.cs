using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private SpawnPoint[] _points;

    private void Start()
    {
        _points = GetComponentsInChildren<SpawnPoint>();
        Coroutine spawnProcces = StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(2f);

        while (true)
        {
            for (int i = 0; i < _points.Length; i++)
            {
                _points[i].CreateEnemy(_enemy);
                Debug.Log($"�������� ������ �� �������� {i}");

                yield return waitForSeconds;
            }
        }
    }
}
