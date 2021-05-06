using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPropAbility : MonoBehaviour, IPropAbility
{
    [SerializeField] private Enemy _currentEnemy;
    public void Attack()
    {

        Destroy(_currentEnemy.gameObject);

        Destroy(gameObject);

    }

    public void SetEnemyToAttack(Enemy enemy)
    {
        _currentEnemy = enemy;
    }
}
