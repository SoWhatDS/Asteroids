using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    internal sealed class AttackBullet : IAttackAdapter
    {
        public void Attack(Vector3 position)
        {
            var bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            bullet.name = "Bullet";
            bullet.transform.position = position;
        }
       
    }
}
