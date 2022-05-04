using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    internal sealed class EnemyBridge 
    {
        private IAttackBridge _attack;
        private IMoveBridge _move;

        public EnemyBridge (IAttackBridge attack, IMoveBridge move)
        {
            _attack = attack;
            _move = move;
        }

        public void Attack()
        {
            _attack.AttackBridge();
        }

        public void Move()
        {
            _move.MoveBridge();
        }

        public void SwitchMove(IMoveBridge move)
        {
            _move = move;
        }
    }
}
