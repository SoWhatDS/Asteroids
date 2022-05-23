using UnityEngine;

namespace Asteroids.Factory
{
    public class Enemy : MonoBehaviour, IUnit
    {
        public float Speed { get; set; }

        public float Health { get; set; }

        public Transform Position {get;  set;}

        public float Damage { get; set;}

        public Sprite EnemySprite { get; set;}

        public static Asteroid CreateAsteroidEnemy(float speed, float health, float damage) 
        {
            Asteroid enemy = GameObject.Instantiate(Resources.Load<Asteroid>("Enemy/Enemy"));            
            enemy.Speed = speed;
            enemy.Health = health;           
            enemy.Damage = damage;         
            return enemy;
        }

        public static Asteroid CreateAsteroidEnemyImmortal(float speed)
        {

            return CreateAsteroidEnemy(speed, 1000, 100);
        }

        public static Asteroid CreateAsteroidEnemyFast(float health, float damage)
        {

            return CreateAsteroidEnemy(20, health, damage);
        }

        public void Move(Transform targetPosition)
        {
            
        }
    }
}
