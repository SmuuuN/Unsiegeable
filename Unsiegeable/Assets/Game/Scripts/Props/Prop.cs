using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Prop : MonoBehaviour
{
    [SerializeField] private IPropAbility _ability;
    [SerializeField] private IHitChecker _hitChecker;

    [SerializeField] private ParticleSystem _destroyParticle;

    private void Awake()
    {
        _ability = GetComponent<IPropAbility>();
        _hitChecker = GetComponent<IHitChecker>();
    }

    private void OnEnable()
    {
        _hitChecker.EnemyHitHappened += OnHit;
    }
    private void OnDisable()
    {
        _hitChecker.EnemyHitHappened -= OnHit;
    }

    private void Attack()
    {
        _ability.Attack();
    }

    private void SetEnemyToAttack(Enemy enemy)
    {
        _ability.SetEnemyToAttack(enemy);
    }

    private void OnHit(Enemy enemy)
    {
        SetEnemyToAttack(enemy);
        Attack();
        
    }  
}
