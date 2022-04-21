
using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyModel 
    {
        public Sprite SpriteEnemy;
        public float HealthEnemy;
        public float SpeedEnemy;
        public float Damage;

        public EnemyModel(Sprite spriteEnemy,float healthEnemy,float speedEnemy,float damage)
        {
            SpriteEnemy = spriteEnemy;
            HealthEnemy = healthEnemy;
            SpeedEnemy = speedEnemy;
            Damage = damage;
        }

      
    }
}
