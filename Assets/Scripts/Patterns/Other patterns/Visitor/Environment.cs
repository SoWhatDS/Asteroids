using UnityEngine;


namespace Asteroids.Visitors
{
    public sealed class Environment : Hit
    {
        [SerializeField] private BulletProjector _projector;

        public BulletProjector Projector => _projector;

        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}
