
using UnityEngine;

namespace Asteroids
{
    public class PlayerCreation : ICreateGameObject
    {
        private readonly PlayerModel _playerModel;

        internal PlayerCreation(PlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        public Transform CreateGameObject()
        {
            GameObject temp = new GameObject("Player");
            temp.AddComponent<SpriteRenderer>().sprite = _playerModel.Sprite;
            temp.AddComponent<Rigidbody2D>();
            temp.AddComponent<BoxCollider2D>();
            return temp.transform;
        }
    }
}
