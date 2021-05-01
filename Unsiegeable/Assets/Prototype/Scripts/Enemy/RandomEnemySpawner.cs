using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _startPlaceSpawner;
    [SerializeField] private Transform _endPlaceSpawner;

    [SerializeField] private GameObject _enemy;

    [SerializeField] private float _spawnEnemyCooldown;

    private void Start()
    {
        BeginSpawnEnemy();
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(_startPlaceSpawner.position.x, _endPlaceSpawner.position.x),
                           Random.Range(_startPlaceSpawner.position.y, _endPlaceSpawner.position.y),
                           Random.Range(_startPlaceSpawner.position.z, _endPlaceSpawner.position.z));
    }

    private void SpawnEnemy()
    {
        Instantiate(_enemy, GetRandomPosition(), Quaternion.identity);
    }

    private void BeginSpawnEnemy()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1, _spawnEnemyCooldown);
    }

}
