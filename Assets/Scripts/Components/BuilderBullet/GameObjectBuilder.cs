using UnityEngine;

namespace Asteroids
{
    public class GameObjectBuilder
    {
        protected GameObject _gameObject;

        public GameObjectBuilder()
        {
            _gameObject = new GameObject();
        }

        public GameObjectBuilder(GameObject gameobject)
        {
            _gameObject = gameobject;
        }

        public GameObjectVisualBuilder Visual => new GameObjectVisualBuilder(_gameObject);

        public GameObjectPhysicalBuilder Physics => new GameObjectPhysicalBuilder(_gameObject);

        public static implicit operator GameObject(GameObjectBuilder builder)
        {
            return builder._gameObject;
        }
    }
}
