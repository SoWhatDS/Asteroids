using UnityEngine;

namespace Asteroids
{
    public class Enemy : MonoBehaviour, IUnit, IEnemyMove
    {
        public float Speed { get; set; }

        public float Health { get; set; }

        public Vector2 EnemyPosition {get;  set;}

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

        public void Move(Transform enemyPosition, Transform targetPosition, float speed)
        {
            enemyPosition.gameObject.transform.position = Vector2.MoveTowards(enemyPosition.gameObject.transform.position, targetPosition.position, speed * Time.deltaTime);
        }

    }
}
