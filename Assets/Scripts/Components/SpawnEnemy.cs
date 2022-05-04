
using UnityEngine;

namespace Asteroids
{
    internal sealed class SpawnEnemy
    {
        private float _RandX;
        private float _RandY;
        private Vector2 _whereToSpawn;
        private float spawnRate = 2.0f;
        private float nextSpawn = 0.0f;
        private EnemyCreationFabric _enemyCreationFabric;
        private Prototype _prototype;
        private float _enemyCount;
   

        public SpawnEnemy(EnemyCreationFabric enemyFabric)
        {
            _enemyCreationFabric = enemyFabric;
           
        }        

        public void EnemySpawn()
        {
             
            if (Time.time > nextSpawn)
            {     
                nextSpawn = Time.time + spawnRate;
                _RandX = Random.Range(-10,10);
                _RandY = 6;
                _whereToSpawn = new Vector2(_RandX, _RandY);
                _enemyCreationFabric.CreateEnemySpawn(_whereToSpawn);
                _enemyCount++;
                if (_enemyCount > 5)
                {
                    _prototype.Clone();
                }
                
                
            }         
        }
    }
}
