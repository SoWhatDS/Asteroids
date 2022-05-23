
using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyModel 
    {
        public Sprite SpriteEnemy;
        public float HealthEnemy;
        public float SpeedEnemy;
        public float Damage;
        public Transform Position;
        public GameObject EnemyPrefub;

        public EnemyModel(Sprite spriteEnemy,float healthEnemy,float speedEnemy,float damage, Transform position,GameObject _prefub)
        {
            SpriteEnemy = spriteEnemy;
            HealthEnemy = healthEnemy;
            SpeedEnemy = speedEnemy;
            Damage = damage;
            Position = position;
            EnemyPrefub = _prefub;           
        }

      
    }
}
