using UnityEngine;

namespace Asteroids
{
    internal class EnemyCreationFabric : IEnemyFactory
    {
        private EnemyModel _enemyModel;

        public EnemyCreationFabric (EnemyModel enemyModel)
        {
            _enemyModel = enemyModel;           
        }        
      
        public Enemy CreateEnemy()
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Enemy"));
            enemy.Speed = _enemyModel.SpeedEnemy;
            enemy.Damage = _enemyModel.Damage;
            enemy.EnemyPosition = new Vector3(1,1);
            enemy.Health = _enemyModel.HealthEnemy;
            enemy.EnemySprite = _enemyModel.SpriteEnemy;
            return enemy;
        }

        public Enemy CreateImmortalEnemy(float health,float damage,Vector3 enemyPosition)
        {
            var enemy = CreateEnemy();
            enemy.Health = health;
            enemy.Damage = damage;
            enemy.EnemyPosition = enemyPosition;
            return enemy;
        }

        public Enemy CreateFastEnemy(float speed)
        {
            var enemy = CreateEnemy();
            enemy.Speed = speed;
            return enemy;
        }

        public Enemy CreateBossEnemy(Vector3 bossPosition,float damage,float speed,float health)
        {
            var enemy = CreateEnemy();
            enemy.Speed = speed;
            enemy.EnemyPosition = bossPosition;
            enemy.Damage = damage;
            enemy.Health = health;
            return enemy;
        }
    }
}