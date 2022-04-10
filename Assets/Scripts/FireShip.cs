
using UnityEngine;


namespace Asteroids
{
    internal sealed class FireShip : IFire
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        public FireShip(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void Fire(bool isFire)
        {
            if (isFire)
            {
                Rigidbody2D temAmmunition = Rigidbody2D.Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);                                 
            }
        }    
    }
}
