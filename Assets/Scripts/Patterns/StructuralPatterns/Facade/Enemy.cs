using UnityEngine;

namespace Asteroids.Facade
{
    internal sealed class Enemy 
    {
        private float Hp { get; }
        private float Damage { get; }
        private Transform Position { get; }

        public Enemy(float hp, float damage,Transform position)
        {
            Hp = hp;
            Damage = damage;
            Position = position;
        }
    }
}
