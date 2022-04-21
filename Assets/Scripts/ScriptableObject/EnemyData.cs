
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "GameData/EnemyData")]

    public sealed class EnemyData : ScriptableObject
    {
        [SerializeField] private Sprite _spriteEnemy;
        [SerializeField] private float _healthEnemy;
        [SerializeField] private float _speedEnemy;
        [SerializeField] private float _damage;
               
        public Sprite SpriteEnemy => _spriteEnemy;
        public float HealthEnemy => _healthEnemy;
        public float SpeedEnemy => _speedEnemy;
        public float Damage => _damage;
       

    }
}