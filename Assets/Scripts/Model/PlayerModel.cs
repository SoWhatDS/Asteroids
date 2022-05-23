using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerModel 
    {
        public Sprite Sprite;

        public float Health;

        public float Speed;

        public float Damage;

        public Vector2 Position;

       
      
        public PlayerModel(Sprite sprite, float health, float speed, float damage, Vector2 position)
        {
            Sprite = sprite;
            Health = health;
            Speed = speed;
            Damage = damage;
            Position = position;
            
        }     
    }
}
