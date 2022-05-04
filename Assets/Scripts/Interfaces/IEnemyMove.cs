
using UnityEngine;


namespace Asteroids
{
    interface IEnemyMove 
    {
        void Move(Transform enemyPosition,Transform targetPosition,float speed);
    }
}