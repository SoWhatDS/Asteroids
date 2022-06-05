using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyController : IExecute, IController
    {       
        private Transform _targetPlayer;        
        private SpawnEnemy _enemySpawn;
        private EnemyCreationFabric _enemyFabric;
        private Enemy _enemy;
        private float enemyCount = 0.0f;

        public EnemyController(EnemyCreationFabric enemyFabric)
        {
            _enemyFabric = enemyFabric;
            _enemy = _enemyFabric.CreateEnemy();            
            _targetPlayer = GameObject.FindObjectOfType<Player>().transform;
            _enemySpawn = new SpawnEnemy(_enemyFabric);
            EnemyTakeDamage enemyTakeDamage = new EnemyTakeDamage(_enemy,GameObject.FindObjectOfType<Player>().Damage);                   
            _enemy.OnTriggerAction += enemyTakeDamage.TakeDamage;                                  
        }    

        public void Update()
        {            
            if (enemyCount < 10)
            {
               
                Enemy _newEnemy = _enemySpawn.EnemySpawn(_enemy);
                //_newEnemy.Move(_targetPlayer.transform, _newEnemy.Speed);               
                enemyCount++;
            }
        }
    }
}

