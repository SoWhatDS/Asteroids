using System.IO;
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "Data", menuName = "GameData/Data")]

    public sealed class GameData : ScriptableObject
    {
        [Tooltip("Загрузка PlayerData из Resources")]
        [SerializeField] private string _playerDataPath;

        [Tooltip("Загрузка BulletData из Resources")]
        [SerializeField] private string _bulletDataPath;

        [Tooltip("Загрузка EnemyData из Resources")]
        [SerializeField] private string _enemyDataPath;

        private PlayerData _player;
        private BulletData _bullet;
        private EnemyData _enemy;

        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>(Path.Combine("Data", _playerDataPath));                   
                }
                return _player;
            }
        }

        public BulletData Bullet
        {
            get 
            {
                if (_bullet == null)
                {
                    _bullet = Load<BulletData>(Path.Combine("Data", _bulletDataPath));
                }
                return _bullet;
            }           
        }

        public EnemyData Enemy
        {
            get 
            {
                if (_enemy == null)
                {
                    _enemy = Load<EnemyData>(Path.Combine("Data", _enemyDataPath));
                }
                return _enemy;
            }
        }

        private T Load<T>(string resourcesPath) where T : Object 
        {
          return Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));          
        }
        
    }
}
