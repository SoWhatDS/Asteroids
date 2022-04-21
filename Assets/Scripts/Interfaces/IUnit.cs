using UnityEngine;

namespace Asteroids
{
    interface IUnit 
    {
        float Speed { get; }
        float Health { get; }
        Vector3 EnemyPosition { get; }
        float Damage { get; }

    }
}
