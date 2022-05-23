using UnityEngine;

namespace Asteroids
{
    internal sealed class PhysicAttack : IAttackBridge
    {
        public void AttackBridge()
        {
            Debug.Log("Физическая атака");
        }
    }
}
