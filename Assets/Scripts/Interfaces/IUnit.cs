using UnityEngine;

namespace Asteroids
{
    interface IUnit 
    {
        float Speed { get; }
        float Health { get; }
        Transform Position { get; }
        float Damage { get; }

    }
}
