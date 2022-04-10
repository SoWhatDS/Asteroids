
using UnityEngine;


namespace Asteroids
{
    internal sealed class AccelerationMove : MoveTransfrom
    {
        private readonly float _acceleration;

        public AccelerationMove(float speed, Transform transform,float acceleration,Rigidbody2D barrelRB) : base(speed, transform,barrelRB)
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
