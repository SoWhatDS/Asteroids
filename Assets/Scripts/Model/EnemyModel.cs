
using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyModel 
    {
        public Sprite SpriteEnemy;
        public float HealthEnemy;
        public float SpeedEnemy;
        public float Damage;
        public Vector2 Position;

        public EnemyModel(Sprite spriteEnemy,float healthEnemy,float speedEnemy,float damage, Vector2 position)
        {
            SpriteEnemy = spriteEnemy;
            HealthEnemy = healthEnemy;
            SpeedEnemy = speedEnemy;
            Damage = damage;
            Position = position;
        }

      
    }
}
