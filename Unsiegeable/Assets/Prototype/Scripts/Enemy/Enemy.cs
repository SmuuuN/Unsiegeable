using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{ 
    [SerializeField] private EnemyStats _data;
    [SerializeField] private IEnemyMovement _enemyMovement;

    private void Start()
    {
        _enemyMovement = GetComponent<IEnemyMovement>();
        _data = GetComponent<EnemyStats>();
    }

    private void FixedUpdate()
    {
        _enemyMovement.MoveEnemy(_data);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Castle>(out var castle))
        {
            castle.ApplyDamage(_data.Damage);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.TryGetComponent<Prop>(out var prop))
        {
            
            Destroy(this.gameObject);
        }
    }

}
