using UnityEngine;

namespace Asteroids
{
    interface IEnemyFactory
    {
        Enemy CreateEnemy();
        Enemy CreateImmortalEnemy(float health, float damage, Vector2 enemyPosition);
        Enemy CreateFastEnemy(float speed);
        Enemy CreateBossEnemy(Vector2 bossPosition, float damage, float speed, float health);
        
    }
}
