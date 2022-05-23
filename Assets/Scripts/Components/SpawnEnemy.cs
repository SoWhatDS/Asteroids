using UnityEngine;

namespace Asteroids
{
    internal sealed class SpawnEnemy
    {
        private float _RandX;
        private float _RandY;
        private Vector3 _whereToSpawn;
        private float spawnRate = 2.0f;
        private float nextSpawn = 0.0f;
        private EnemyCreationFabric _enemyCreationFabric;
        private ICopyble _copy;
   

        public SpawnEnemy(EnemyCreationFabric enemyFabric)
        {
            _enemyCreationFabric = enemyFabric;
           
        }        

        public Enemy EnemySpawn(Enemy prototype)
        {                       
            if (Time.time > nextSpawn)
            {               
                nextSpawn = Time.time + spawnRate;
                _RandX = Random.Range(-10,10);
                _RandY = 6;
                _whereToSpawn = new Vector2(_RandX, _RandY);
                _copy = prototype.copy(_whereToSpawn);
                return (Enemy)_copy;
            }
            return null;
        }
    }
}
