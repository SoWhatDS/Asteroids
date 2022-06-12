using UnityEngine;

namespace Asteroids
{
    internal sealed class FireShip : IFire
    {
        private readonly GameObject _bullet;     
        private  Transform _barrel;
        private readonly float _force;
     
        

        public FireShip(GameObject bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;          
            ServiceLocator.SetService<ViewServices>(new ViewServices());          
        }

        public void Fire(bool isFire)
        {
            if (isFire)
            {   
                    var bullet = ServiceLocator.Resolve<ViewServices>().Instantiate<Rigidbody2D>(_bullet.gameObject, new Vector2(20, 20));
                    bullet.position = _barrel.position;
                    bullet.AddForce(_barrel.up * _force);
                // ServiceLocator.Resolve<ViewServices>().Destroy(bullet.gameObject);            

            }
        }        
    }
}
