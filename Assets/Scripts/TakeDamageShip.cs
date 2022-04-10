
using UnityEngine;


namespace Asteroids
{
    internal sealed class TakeDamageShip : ITakeDamage
    {
        private float _hp;

        public TakeDamageShip(float hp)
        {
            _hp = hp;
        }

        public void TakeDamage(GameObject barrel)
        {
            if (_hp <= 0)
            {
                GameObject.Destroy(barrel);
            }
            else
            {
                _hp--;
            }
        }
    }
}
