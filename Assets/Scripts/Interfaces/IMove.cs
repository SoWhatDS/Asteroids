using UnityEngine;

namespace Asteroids
{
    interface IMove 
    {       
        void Move(float horizontal, float vertical, float deltaTime, Rigidbody2D barrelRB);
    }
}
