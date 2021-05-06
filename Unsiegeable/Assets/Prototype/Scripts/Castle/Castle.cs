using System;
using UnityEngine;

public class Castle : MonoBehaviour
{
    [SerializeField] private float _healthPoints;
    public float HealthPoints { get => _healthPoints; private set { } }

    public  Action HealthChanged;
    public Action DeathHappened;
    public void ApplyDamage(int damage)
    {
        if(damage <= 0 )
        {
            return;
        }

        if(damage > _healthPoints)
        {
            Defeat();

            return;
        }

        _healthPoints = _healthPoints - damage;

        HealthChanged.Invoke();

        if(_healthPoints <= 0)
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        DeathHappened?.Invoke();
    }
}
