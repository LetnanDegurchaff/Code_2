using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public void CreateEnemy(Enemy enemy)
    {
        Instantiate<Enemy>(enemy, transform.position, Quaternion.identity);
    }
}