
using System;

namespace Asteroids.Observer.Example1
{
    public interface IHit
    {
        Action<float> OnHitChange { get; set; }
    }
}
