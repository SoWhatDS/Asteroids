using UnityEngine;

namespace Asteroids
{
    internal sealed class MagicAttack : IAttackBridge
    {
        public void AttackBridge()
        {
            Debug.Log("магическая атака");
        }
    }
}
