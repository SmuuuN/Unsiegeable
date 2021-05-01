using System;
using UnityEngine;

public class DefaultHitChecker : MonoBehaviour, IHitChecker
{
    public event Action<Enemy> HitHappened;

    private void OnCollisionEnter(Collision collision)
    {
        if(TryGetComponent<Enemy>(out var enemy))
        {
            HitHappened(enemy); 
        }
    }
}
