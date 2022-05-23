using UnityEngine;

namespace Asteroids
{
    internal sealed class Weapon : IWeapon
    {
        private readonly Rigidbody _bullet;
        private readonly Transform _positionBarrel;
        private float _force = 999.0f;
        private float _timeToDestroy = 10.0f;

        public Weapon(Rigidbody bulletPrefab, Transform positionBarrel)
        {
            _bullet = bulletPrefab;
            _positionBarrel = positionBarrel;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet, _positionBarrel.position, Quaternion.identity);
            bullet.AddForce(_positionBarrel.forward * _force);
            Object.Destroy(bullet.gameObject, _timeToDestroy);
        }
    }
}
