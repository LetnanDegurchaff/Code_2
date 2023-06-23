using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private SpawnPoint[] _points;
    private float _spawnInterval = 2f;

    private void Start()
    {
        _points = GetComponentsInChildren<SpawnPoint>();
        Coroutine spawnProcces = StartCoroutine(StartCreating());
    }

    private IEnumerator StartCreating()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_spawnInterval);

        while (true)
        {
            for (int i = 0; i < _points.Length; i++)
            {
                CreateEnemy(_enemy, _points[i].transform.position);

                yield return waitForSeconds;
            }
        }
    }


    public void CreateEnemy(Enemy enemy, Vector3 position)
    {
        Instantiate<Enemy>(enemy, position, Quaternion.identity);
    }
}
