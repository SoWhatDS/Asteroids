using UnityEngine;

namespace Asteroids
{
    internal class MoveRigidbody : IMove
    {             
        private readonly Rigidbody2D _playerRB;
        private Vector2 _direction = Vector2.zero;

        public float Speed { get; protected set; } 
        
        public MoveRigidbody(float speed,Rigidbody2D playerRB)
        {
            Speed = speed;          
            _playerRB = playerRB;
        }        

        public void Move(float horizontal, float vertical, float deltaTime,Rigidbody2D playerRB)
        {
            float speed = Speed * deltaTime;
            _direction.x = horizontal;
            _direction.y = vertical;           
            _playerRB.MovePosition(_playerRB.position + speed *_direction);
        }
    }
}
