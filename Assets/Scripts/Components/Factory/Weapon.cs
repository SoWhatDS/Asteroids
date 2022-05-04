using Asteroids;
using UnityEngine;


namespace AsteroidsFactory
{
    internal sealed class Weapon : IWeapon
    {
        private readonly Rigidbody _prefubBullet;
        private readonly IViewServices _viewServices;

        public Weapon(Rigidbody prefubBullet, IViewServices viewServices)
        {
            _prefubBullet = prefubBullet;
            _viewServices = viewServices;
        }

        public void Fire()
        {
            var bullet = _viewServices.Instantiate<Rigidbody>(_prefubBullet.gameObject);
            bullet.AddForce(Vector3.forward);
            _viewServices.Destroy(bullet.gameObject);
        }
    }
}
