using System.Collections.Generic;
using UnityEngine;

public class RockPropAbility : MonoBehaviour, IPropAbility
{
    [SerializeField] private List<Enemy> _currentEnemies = new List<Enemy>();

    public void Attack()
    {
        foreach(var enemy in _currentEnemies)
        {
            Destroy(enemy.gameObject);
        }
        Destroy(gameObject);
    }

    public void SetEnemyToAttack(Enemy enemy)
    {
        _currentEnemies.Add(enemy);   
    }
}
