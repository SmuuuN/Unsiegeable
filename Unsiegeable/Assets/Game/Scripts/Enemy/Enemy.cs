using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{ 
    public EnemyStats EnemyData;

    public event Action EnemyHit;

    [SerializeField] private IEnemyMovement _enemyMovement;

    private void Start()
    {
        _enemyMovement = GetComponent<IEnemyMovement>();
        EnemyData = GetComponent<EnemyStats>();
    }

    private void FixedUpdate()
    {
        _enemyMovement.MoveEnemy(EnemyData);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Castle>(out var castle))
        {
            EnemyHit?.Invoke();

            castle.ApplyDamage(EnemyData.Damage);
            Destroy(this.gameObject);
        }     
    }
}
