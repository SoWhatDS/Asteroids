using System;


namespace Asteroids.Observer.Example2
{
    internal sealed class Asteroid : IDeath
    {
        private float _hp;
        public string Name { get; }

        public event Action<string> OnDeathChange;

        public float Hp
        {
            set 
            {
                _hp = value;
                if (_hp <= 0)
                {
                    OnDeathChange?.Invoke(Name);
                }
            }
        }
    }
}
