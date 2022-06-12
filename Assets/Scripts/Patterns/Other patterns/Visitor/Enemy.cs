using UnityEngine;

namespace Asteroids.Visitors
{
    public sealed class Enemy : Hit
    {
        public TextMesh TextMesh;

        public override void Activate(IDealingDamage value, InfoCollision infoColission)
        {
            value.Visit(this, infoColission);
        }
    }
}
