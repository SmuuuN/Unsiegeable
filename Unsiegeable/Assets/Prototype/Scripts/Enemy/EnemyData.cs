using UnityEngine;

[CreateAssetMenu(fileName ="Enemy Data", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    public int Health = 0;
    public int Armor = 0;
    public int Damage;
    public float MovementSpeed = 0;
}
