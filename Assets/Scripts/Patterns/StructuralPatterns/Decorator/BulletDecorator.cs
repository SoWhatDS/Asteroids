using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletDecorator : IAmmunitionDecorator
    {
        public Rigidbody BulletInstance { get; }

        public float TimeToDestroy { get; }

        public BulletDecorator(Rigidbody bulletInstance, float timeToDestroy)
        {
            BulletInstance = bulletInstance;
            TimeToDestroy = timeToDestroy;
        }

        
    }
}
