using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerInitialization : IInitialization,IController
    {
        private readonly PlayerCreation _playerCreation;
        private readonly Transform _player;
        private readonly Rigidbody2D _playerRB;
        
        public PlayerInitialization(PlayerCreation playerCreation)
        {
            _playerCreation = playerCreation;
            _player = _playerCreation.CreateGameObject();
            _player.position = Vector3.zero;
            _playerRB = _player.gameObject.GetComponent<Rigidbody2D>();
            _playerRB.gravityScale = 0f;
            _player = _player.gameObject.GetComponent<Transform>();
        }

        public Transform GetPlayerTransform()
        {
            return _player;
        }

        public Rigidbody2D GetPlayerRigidbody2D()
        {
            return _playerRB;
        }
    }
}
