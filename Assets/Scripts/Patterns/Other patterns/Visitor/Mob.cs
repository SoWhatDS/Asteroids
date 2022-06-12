using UnityEngine;

namespace Asteroids.Visitors
{
    public class Mob : Hit
    {
      
        public TextMesh TextMesh;

        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            throw new System.NotImplementedException();
        }
    }
}
