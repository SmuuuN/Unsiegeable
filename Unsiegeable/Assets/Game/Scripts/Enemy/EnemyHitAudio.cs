using UnityEngine;

public class EnemyHitAudio : MonoBehaviour
{
    [SerializeField] private RandomEnemySpawner _enemySpawner;
    [SerializeField] private AudioSource _hitSound;

    private void OnEnable()
    {
        _hitSound = GetComponent<AudioSource>();

        _enemySpawner.EnemySpawned += OnEnemySpawned;
    }

    private void OnDisable()
    {
        _enemySpawner.EnemySpawned -= OnEnemySpawned;
    }

    private void OnEnemySpawned(Enemy enemy)
    {
        enemy.EnemyHit += OnHit;
    }

    private void OnHit()
    {
        _hitSound.Play();
    }

}
