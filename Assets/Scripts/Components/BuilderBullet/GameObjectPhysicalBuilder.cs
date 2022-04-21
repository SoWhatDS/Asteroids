using UnityEngine;


namespace Asteroids
{
    public sealed class GameObjectPhysicalBuilder : GameObjectBuilder
    {
        public GameObjectPhysicalBuilder(GameObject gameObject) : base(gameObject) 
        { 
        
        }

        public GameObjectPhysicalBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }

        public GameObjectPhysicalBuilder Transform()
        {
            GetOrAddComponent<Transform>();
            return this;
        }

        public GameObjectPhysicalBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component 
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
