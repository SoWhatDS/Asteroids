using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyInitialization : IInitialization, IController
    {
        private readonly EnemyCreationFabric _enemyFabric;
  
        public EnemyInitialization(EnemyCreationFabric enemyFabric)
        {
            _enemyFabric = enemyFabric;                      
        }
      
    }
}
