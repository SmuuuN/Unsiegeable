using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private EnemyData _data;

    [SerializeField] private int _damage;
    [SerializeField] private float _movementSpeed;

    private void Awake()
    {
        _damage = _data.Damage;
        _movementSpeed = _data.MovementSpeed;
    }
    public int Damage { get => _damage; set => _damage = value ; }
    public float MovementSpeed { get => _movementSpeed; set => _movementSpeed =  value; }

}
