using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    internal class MoveTransfrom : IMove
    {
        
        private readonly Transform _transform;       
        private readonly Rigidbody2D _barrelRB;
        private Vector2 _direction = Vector2.zero;

        public float Speed { get; protected set; }

        public MoveTransfrom(float speed,Transform transform,Rigidbody2D barrelRB)
        {
            Speed = speed;
            _transform = transform;
            _barrelRB = barrelRB;
        }        

        public void Move(float horizontal, float vertical, float deltaTime,Rigidbody2D barrelRB)
        {
            float speed = Speed * deltaTime;
            _direction.x = horizontal;
            _direction.y = vertical;           
            _barrelRB.MovePosition(_barrelRB.position + speed*_direction);
        }
    }
}
