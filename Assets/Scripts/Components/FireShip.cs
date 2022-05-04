using UnityEngine;

namespace Asteroids
{
    internal sealed class FireShip : IFire
    {
        private readonly Rigidbody2D _bullet;     
        private  Transform _barrel;
        private readonly float _force;
    
       

        public FireShip(Rigidbody2D bullet, Transform barrel, float force)
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
                var bullet = ServiceLocator.Resolve<ViewServices>().Instantiate<Rigidbody2D>(_bullet.gameObject);                                                
                bullet.AddForceAtPosition(_barrel.up * _force,_barrel.position,ForceMode2D.Force);                
                ServiceLocator.Resolve<ViewServices>().Destroy(bullet.gameObject);              
            }
        }        
    }
}
