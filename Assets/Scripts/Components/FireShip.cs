using UnityEngine;


namespace Asteroids
{
    internal sealed class FireShip : IFire
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;
        private readonly IViewServices _viewServices;
              
        public FireShip(Rigidbody2D bullet, Transform barrel, float force,IViewServices viewServices)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
            _viewServices = viewServices;           
        }
     
        public void Fire(bool isFire)
        {
            if (isFire)
            {
                var bullet = _viewServices.Instantiate<Rigidbody2D>(_bullet.gameObject);
                bullet.AddForce(_barrel.up * _force);
                _viewServices.Destroy(bullet.gameObject);                             
            }
        }        
    }
}
