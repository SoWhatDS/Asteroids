using System;

namespace Asteroids.Observer.Example2
{
    internal interface IDeath
    {
      string Name { get; }

      event Action<string> OnDeathChange;
    }
}
