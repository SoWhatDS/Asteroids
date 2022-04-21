using UnityEngine;

namespace Asteroids
{
    interface IMove 
    {
        float Speed { get; }

        void Move(float horizontal, float vertical, float deltaTime, Rigidbody2D barrelRB);
    }
}
