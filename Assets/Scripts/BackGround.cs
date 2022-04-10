using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    
    internal sealed class BackGround 
    {
        [SerializeField] private SpriteRenderer _sprite;

        private float _speed;
        private float _spriteMinY;
        private Vector2 restartPos;

        public BackGround()
        { 
        
        }
    }
}
