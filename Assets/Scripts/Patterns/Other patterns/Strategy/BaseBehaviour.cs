using UnityEngine;

namespace Asteroids.Startegy
{
    public abstract class BaseBehaviour : ScriptableObject
    {
        [SerializeField] protected float _speed;

        public abstract void Behaviour(Transform value);
    }
}
