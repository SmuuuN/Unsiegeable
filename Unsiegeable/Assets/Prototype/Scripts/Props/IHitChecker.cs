using System;

public interface IHitChecker
{
    event Action<Enemy> EnemyHitHappened;
    event Action HitHapened;
}
