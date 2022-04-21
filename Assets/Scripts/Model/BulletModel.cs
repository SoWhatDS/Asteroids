
using UnityEngine;


namespace Asteroids
{
    internal sealed class BulletModel
    {
        public Sprite Sprite;

        public Rigidbody2D BulletRB;

        public float Force;

        public BulletModel(Sprite sprite, Rigidbody2D bulletRB, float force)
        {
            Sprite = sprite;
            BulletRB = bulletRB;
            Force = force;

        }
    }
}
