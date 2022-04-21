using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletInitialization : IInitialization, IController
    {
        private readonly BulletCreation _bulletCreation;             
        private readonly GameObject _bullet;

        public BulletInitialization(BulletCreation bulletCreation)
        {
            _bulletCreation = bulletCreation;
            _bullet = _bulletCreation.CreateGameObject();
            _bullet.gameObject.SetActive(false);                               
        }          
    }
}
