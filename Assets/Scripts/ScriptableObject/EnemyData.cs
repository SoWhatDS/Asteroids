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
        [SerializeField] private Transform _position;
        [SerializeField] private GameObject _prefub;
       
    
               
        public Sprite SpriteEnemy => _spriteEnemy;
        public float HealthEnemy => _healthEnemy;
        public float SpeedEnemy => _speedEnemy;
        public float Damage => _damage;
        public Transform Position => _position;
        public GameObject Prefub => _prefub;
                  
    }
}
