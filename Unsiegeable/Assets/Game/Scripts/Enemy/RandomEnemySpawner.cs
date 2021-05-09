using System;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _startPlaceSpawner;
    [SerializeField] private Transform _endPlaceSpawner;

    [SerializeField] private Enemy _enemy;

    [SerializeField] private float _spawnEnemyCooldown;

    public Action<Enemy> EnemySpawned;

    private void Start()
    {
        BeginSpawnEnemy();
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(UnityEngine.Random.Range(_startPlaceSpawner.position.x, _endPlaceSpawner.position.x),
                           UnityEngine.Random.Range(_startPlaceSpawner.position.y, _endPlaceSpawner.position.y),
                           UnityEngine.Random.Range(_startPlaceSpawner.position.z, _endPlaceSpawner.position.z));
    }

    private void SpawnEnemy()
    {
        var enemy =  Instantiate(_enemy, GetRandomPosition(), Quaternion.identity);

        EnemySpawned?.Invoke(enemy);
    }

    private void BeginSpawnEnemy()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1, _spawnEnemyCooldown);
    }

}
