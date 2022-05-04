using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyController : IExecute, IController
    {       
        private Transform _targetPlayer;        
        private SpawnEnemy _enemySpawn;
        private EnemyCreationFabric _enemyFabric;         

        public EnemyController(Transform playerTransform,EnemyCreationFabric enemyFabric)
        {           
            _targetPlayer = playerTransform;
            _enemyFabric = enemyFabric;
            _enemySpawn = new SpawnEnemy(_enemyFabric);           
        }

        public void Update()
        {            
           _enemySpawn.EnemySpawn();
           Enemy enemy = GameObject.FindObjectOfType<Asteroid>();
           enemy.Move(enemy.gameObject.transform,_targetPlayer.transform, enemy.Speed);
           
        }
    }
}

