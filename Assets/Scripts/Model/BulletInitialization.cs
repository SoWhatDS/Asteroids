using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletInitialization : IInitialization, IController
    {
        private readonly BulletCreation _bulletCreation;
        private readonly Transform _bullet;
        private readonly Rigidbody2D _bulletRB;

        public BulletInitialization(BulletCreation bulletCreation)
        {
            _bulletCreation = bulletCreation;
            _bullet = _bulletCreation.CreateGameObject();
            _bullet.gameObject.SetActive(false);
            _bullet.position = new Vector3(50,10,10);
            _bulletRB = _bullet.gameObject.GetComponent<Rigidbody2D>();            
            _bullet = _bullet.gameObject.GetComponent<Transform>();
        }

        public Transform GetPlayerTransform()
        {
            return _bullet;
        }

        public Rigidbody2D GetPlayerRigidbody2D()
        {
            return _bulletRB;
        }
    }
}
