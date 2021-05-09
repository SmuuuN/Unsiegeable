using System;
using UnityEngine;

public class RockHitChecker : MonoBehaviour, IHitChecker
{
    public event Action<Enemy> EnemyHitHappened;
    public event Action HitHapened;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Enemy>(out var enemy))
        {
            EnemyHitHappened?.Invoke(enemy);
            HitHapened?.Invoke();
        } 
    }
}
