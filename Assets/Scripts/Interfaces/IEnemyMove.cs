
using UnityEngine;


namespace Asteroids
{
    interface IEnemyMove 
    {
        void Move(Transform targetPosition,float speed);
    }
}