using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    internal sealed class Detachment : IAttackComposite
    {
        private List<IAttackComposite> _attacks = new List<IAttackComposite>();

        public void AddUnit(IAttackComposite attack)
        {
            _attacks.Add(attack);
        }

        public void RemoveUnit(IAttackComposite attack)
        {
            _attacks.Remove(attack);
        }

        public void AttackComposite(Unit unit)
        {
            foreach (var attack in _attacks)
            {
                attack.AttackComposite(unit);
            }
        }
    }
}
