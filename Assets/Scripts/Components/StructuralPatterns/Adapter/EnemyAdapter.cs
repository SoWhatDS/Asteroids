using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    internal sealed class EnemyAdapter : IFireAdapter
    {
        private readonly IAttackAdapter _attack = new AttackBullet();

        public void Fire(Vector3 position)
        {
            _attack.Attack(position);
        }
    }
}
