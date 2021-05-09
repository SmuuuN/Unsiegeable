using System;
using UnityEngine;

public class DefaultHitChecker : MonoBehaviour, IHitChecker
{
    public event Action<Enemy> EnemyHitHappened;
    public event Action HitHapened;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Enemy>(out var enemy))
        {
            HitHapened?.Invoke();
            EnemyHitHappened?.Invoke(enemy);
            
        }
    }
}
