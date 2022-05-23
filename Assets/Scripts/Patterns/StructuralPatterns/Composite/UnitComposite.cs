using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Unit : IAttackComposite
    {
        public float Hp { get; private set; }
        public float Damage { get; }

        public void AttackComposite(Unit unit)
        {
            unit.Hp -= Damage;
        }
    }
}
