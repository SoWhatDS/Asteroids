
using UnityEngine;


namespace Asteroids
{
    internal sealed class AccelerationMove : MoveRigidbody
    {
        private readonly float _acceleration;

        public AccelerationMove(float speed,float acceleration,Rigidbody2D playerRB) : base(speed, playerRB)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration; 
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
