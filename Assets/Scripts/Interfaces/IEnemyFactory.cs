using UnityEngine;

namespace Asteroids
{
    interface IEnemyFactory
    {
        Enemy CreateEnemy();
        Enemy CreateImmortalEnemy(float health, float damage, Vector3 enemyPosition);
        Enemy CreateFastEnemy(float speed);
        Enemy CreateBossEnemy(Vector3 bossPosition, float damage, float speed, float health);
        
    }
}
