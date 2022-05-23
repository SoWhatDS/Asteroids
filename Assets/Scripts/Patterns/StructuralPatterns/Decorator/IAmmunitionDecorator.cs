using UnityEngine;

namespace Asteroids
{
    interface IAmmunitionDecorator 
    {
       public Rigidbody BulletInstance { get; }
       public float TimeToDestroy { get; }

    }
}
