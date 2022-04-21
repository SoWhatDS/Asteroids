using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletCreation : ICreateGameObject
    {
        private readonly BulletModel _bulletModel;

        internal BulletCreation(BulletModel bulletModel)
        {
            _bulletModel = bulletModel;
        }

        public Transform CreateGameObject()
        {
            GameObject temp = new GameObject("Bullet");
            temp.AddComponent<SpriteRenderer>().sprite = _bulletModel.Sprite;
            temp.AddComponent<Rigidbody2D>();
            return temp.transform;
        }
    }
}
