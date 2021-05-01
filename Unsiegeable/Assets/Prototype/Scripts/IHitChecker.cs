using System;

public interface IHitChecker
{
    event Action<Enemy> HitHappened;
}
