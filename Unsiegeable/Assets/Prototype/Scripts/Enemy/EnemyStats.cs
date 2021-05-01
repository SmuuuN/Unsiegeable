using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private EnemyData _data;

    public int Health { get => _data.Health; set => value = _data.Health; }
    public int Armor { get => _data.Health; set => value = _data.Armor; }
    public int Damage { get => _data.Health; set => value = _data.Damage; }
    public float MovementSpeed { get => _data.Health; set => value = _data.MovementSpeed; }

}
