using UnityEngine;


namespace Asteroids
{
    internal sealed class TakeDamageShip : ITakeDamage
    {
        private float _playerHp;
        private float _damageEnemy;

        public TakeDamageShip(float playerHp, float damageEnemy)
        {
            _playerHp = playerHp;
            _damageEnemy = damageEnemy;            
        }

        public void TakeDamage(GameObject enemy)
        {
            if (_playerHp <= 0)
            {
                Debug.Log("GameOver");
                GameObject.Destroy(enemy);
            }
            else
            {
                _playerHp -= _damageEnemy;
                GameObject.Destroy(enemy);
            }
        }
    }
}
