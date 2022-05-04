using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerModel 
    {
        public Sprite Sprite;

        public float Health;

        public float Speed;

       
      
        public PlayerModel(Sprite sprite, float health, float speed)
        {
            Sprite = sprite;
            Health = health;
            Speed = speed;         
            
        }     
    }
}
