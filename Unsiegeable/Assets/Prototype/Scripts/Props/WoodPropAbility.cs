using System.Collections.Generic;
using UnityEngine;

public class WoodPropAbility : MonoBehaviour, IPropAbility
{
    [SerializeField] private List<Enemy> _currentEnemies = new List<Enemy>();

    [SerializeField] private float _speedAmount = 0.1f;
    
    public void Attack()
    {
        SetLowerMovementSpeed();
        Invoke(nameof(StopEffect), 5f);
        Destroy(gameObject);
    }

    public void SetEnemyToAttack(Enemy enemy)
    {
        _currentEnemies.Add(enemy);
    }

    private void SetLowerMovementSpeed()
    {
        foreach(var enemy in _currentEnemies)
        {
            enemy.EnemyData.MovementSpeed *= _speedAmount;
        }
    }

    private void StopEffect()
    {
        foreach (var enemy in _currentEnemies)
        {
            enemy.EnemyData.MovementSpeed /= _speedAmount;
        }
    }
}
