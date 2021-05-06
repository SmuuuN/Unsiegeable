using UnityEngine;

[CreateAssetMenu(fileName ="Enemy Data", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    public int Damage;
    public float MovementSpeed = 0;
}
