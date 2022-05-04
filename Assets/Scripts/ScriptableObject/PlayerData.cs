using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "GameData/PlayerData")]

    public sealed class PlayerData : ScriptableObject
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private float _health;
        [SerializeField] private float _speed;
       
       
        public Sprite Sprite => _sprite;
        public float Health => _health;
        public float Speed => _speed;
        
    }
}
