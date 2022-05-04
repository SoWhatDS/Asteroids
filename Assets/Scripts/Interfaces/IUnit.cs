using UnityEngine;

namespace Asteroids
{
    interface IUnit 
    {
        float Speed { get; }
        float Health { get; }
        Vector2 EnemyPosition { get; }
        float Damage { get; }

    }
}
