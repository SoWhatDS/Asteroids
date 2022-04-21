
using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyController : IExecute, IController
    {       
        private Transform _targetPlayer;
        private Enemy _enemy;

        public EnemyController(Transform playerTransform, IEnemyFactory enemyFabric)
        {           
            _targetPlayer = playerTransform;
            _enemy = enemyFabric.CreateEnemy();
            _enemy = enemyFabric.CreateFastEnemy(50);
            _enemy = enemyFabric.CreateBossEnemy(new Vector3(2,2),100,30,300);
        }

        public void Update()
        {
            _enemy.Move(_targetPlayer,_enemy.Speed);
           
        }
    }
}

