using UnityEngine;
using Asteroids.Visitors;


namespace Asteroids
{
    internal sealed class EnemyTakeDamage : ITakeDamage
    {
        private Enemy _enemy;
        private float _playerDamage;
       

        public EnemyTakeDamage(Enemy enemy,float playerDamage)
        {
            _enemy = enemy;
            _playerDamage = playerDamage;
        }


        public void TakeDamage(GameObject enemy)
        {
            if (enemy.GetComponent<Enemy>().Health <= 0)
            {               
                GameObject.Destroy(enemy);
                Debug.Log(enemy.GetComponent<Enemy>().Health);

            }
            else
            {
                Debug.Log(enemy.GetComponent<Enemy>().Health);
                enemy.GetComponent<Enemy>().Health -= _playerDamage;
                _enemy.Activate(new ConsoleDisplay(), new InfoCollision(_playerDamage));
                _enemy.Activate(new ApplyDamage(), new InfoCollision(_playerDamage));

            }
        }
    }
}
