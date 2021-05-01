using UnityEngine;

[CreateAssetMenu(menuName = "Prop Data Menu")]
public class PropData : ScriptableObject
{
    public int Damage = 0;
    public float DamageRadius = 0;

    public float ProjectileSpeed = 0;

    public string Description = "";

    public bool Splash = false;
}
