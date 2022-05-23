using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "GameData/PlayerData")]

    public sealed class PlayerData : ScriptableObject
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private float _health;
        [SerializeField] private float _speed;
        [SerializeField] private float _damage;
        [SerializeField] private Vector2 _position;
       
       
        public Sprite Sprite => _sprite;
        public float Health => _health;
        public float Speed => _speed;
        public float Damage => _damage;

        public Vector2 Position => _position;
        
    }
}
