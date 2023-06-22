using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Transform _tansform;

    public Vector3 GetPosition()
    {
        return _tansform.position;
    }

    public void CreateObject(GameObject gameObject)
    {
        Instantiate(gameObject, _tansform.position, Quaternion.identity);
    }

    private void Start()
    {
        _tansform = GetComponent<Transform>();
    }
}