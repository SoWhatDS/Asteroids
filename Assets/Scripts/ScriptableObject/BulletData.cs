using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "BulletData", menuName = "GameData/BulletData")]

    public sealed class BulletData : ScriptableObject
    {
        [SerializeField] private Sprite _spriteBullet;
        [SerializeField] private Rigidbody2D _bulletRB;
        [SerializeField] private float _force;

        public Sprite Sprite => _spriteBullet;
        public Rigidbody2D BulletRB => _bulletRB;
        public float Force => _force;

    }
}
