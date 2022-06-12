using UnityEngine;

namespace Asteroids
{
    public class PlayerCreation : IPlayerFactory
    {
        private readonly PlayerModel _playerModel;
      
        

        internal PlayerCreation(PlayerModel playerModel)
        {
            _playerModel = playerModel;          
        }

        public Player CreatePlayer()
        {
            Player player = GameObject.Instantiate(Resources.Load<Player>("Player/Player"));
            player.Health = _playerModel.Health;
            player.Speed = _playerModel.Speed;
            player.Damage = _playerModel.Damage;
            player.gameObject.GetComponent<SpriteRenderer>().sprite = _playerModel.Sprite;
            player.gameObject.AddComponent<Rigidbody2D>().gravityScale = 0.0f;
            player.gameObject.AddComponent<BoxCollider2D>();           
            return player;
        }

    }
}
