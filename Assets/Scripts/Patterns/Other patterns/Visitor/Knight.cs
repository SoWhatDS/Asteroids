using UnityEngine;

namespace Asteroids.Visitors
{
    public sealed class Knight : Hit
    {
        public float Armor;
        public TextMesh TextMesh;

        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }
    }
}
