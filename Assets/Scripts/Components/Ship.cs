using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship : Player,IMove,IRotation,IFire,ITakeDamage
    {
        private IMove _moveImplimintation;
        private IRotation _rotationImplimintation;
        private IFire _fireImplimintation;
        private ITakeDamage _takeDamageImplimintation;
        

        public Ship(IMove moveImplimitation, IRotation rotationImplimintetion, IFire fireImplimintation, ITakeDamage takeDamageImplimintation)
        {
            _moveImplimintation = moveImplimitation;
            _rotationImplimintation = rotationImplimintetion;
            _fireImplimintation = fireImplimintation;
            _takeDamageImplimintation = takeDamageImplimintation;
        }

        public void Move(float horizontal, float vertical, float deltaTime, Rigidbody2D playerRB)
        {
            _moveImplimintation.Move(horizontal, vertical, deltaTime, playerRB);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplimintation.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (_moveImplimintation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplimintation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        public void Fire(bool isFire)
        {
            _fireImplimintation.Fire(isFire);
        }

        public void TakeDamage(GameObject barrel)
        {
            _takeDamageImplimintation.TakeDamage(barrel);
        }
    }
}
