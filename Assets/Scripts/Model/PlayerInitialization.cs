using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerInitialization : IInitialization,IController
    {
        private readonly PlayerCreation _playerCreation;
        private readonly Player _player;      
        
        public PlayerInitialization(PlayerCreation playerCreation)
        {
            _playerCreation = playerCreation;
            _player = _playerCreation.CreatePlayer();
            _player.transform.position = Vector2.zero;           
        }

        public Transform GetPlayerTransform()
        {
            return _player.transform;
        }

        public Rigidbody2D GetPlayerRigidbody2D()
        {
            return _player.GetComponent<Rigidbody2D>();
        }
    }
}
