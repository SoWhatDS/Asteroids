using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyCreationFabric : IEnemyFactory
    {
        private EnemyModel _enemyModel;

        public EnemyCreationFabric (EnemyModel enemyModel)
        {    
            _enemyModel = enemyModel;                      
        }        
      
        public Enemy CreateEnemy()
        {
            Enemy enemy = GameObject.Instantiate(Resources.Load<Enemy>("Enemy/Enemy"));
            enemy.Speed = _enemyModel.SpeedEnemy;
            enemy.Health = _enemyModel.HealthEnemy;
            enemy.Damage = _enemyModel.Damage;
            enemy.Position = _enemyModel.Position;          
            enemy.gameObject.GetComponent<SpriteRenderer>().sprite = _enemyModel.SpriteEnemy;
            enemy.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;
            enemy.gameObject.AddComponent<Rigidbody2D>().gravityScale = 0.0f;            
            return enemy;

        }

        public Enemy CreateEnemySpawn(Vector2 spawnPosition)
        {
            var enemy = CreateEnemy();           
            enemy.Position.position = spawnPosition;
            return enemy;

        }

        public Enemy CreateImmortalEnemy(float health, float damage, Vector2 enemyPosition)
        {
            var enemy = CreateEnemy();
            enemy.Health = health;
            enemy.Damage = damage;
            enemy.Position.position = enemyPosition;
            return enemy;
        }

        public Enemy CreateFastEnemy(float speed)
        {
            var enemy = CreateEnemy();
            enemy.Speed = speed;
            return enemy;
        }

        public Enemy CreateBossEnemy(Vector2 bossPosition, float damage, float speed, float health)
        {
            var enemy = CreateEnemy();
            enemy.Speed = speed;
            enemy.Position.position = bossPosition;
            enemy.Damage = damage;
            enemy.Health = health;
            return enemy;
        }
    }
}