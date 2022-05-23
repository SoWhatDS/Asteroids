
using UnityEngine;

namespace Asteroids
{
    internal sealed class ExampleBridge : MonoBehaviour
    {
        private EnemyBridge _enemyBridge;

        private void Start()
        {
            _enemyBridge = new EnemyBridge(new MagicAttack(), new FlyMove());
            _enemyBridge.SwitchMove(new swimMove());
            _enemyBridge.Attack();
            _enemyBridge.Move();
            _enemyBridge.SwitchAttack(new PhysicAttack());
            _enemyBridge.SwitchMove(new FlyMove());
            _enemyBridge.Attack();
            _enemyBridge.Move();
        }

        
    }
}
