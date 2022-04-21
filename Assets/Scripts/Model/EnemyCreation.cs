using UnityEngine;

namespace Asteroids
{
    public class EnemyCreation 
    {
        private IEnemyFactory _enemyFabric;

        internal EnemyCreation(IEnemyFactory enemyFabric)
        {
            _enemyFabric = enemyFabric;
        }
       
    }
}
