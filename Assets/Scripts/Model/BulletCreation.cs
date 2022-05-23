using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletCreation 
    {
        private readonly BulletModel _bulletModel;
        GameObjectBuilder gameObjectBuilder = new GameObjectBuilder();

        internal BulletCreation(BulletModel bulletModel)
        {
            _bulletModel = bulletModel;
        }

        public GameObject CreateGameObject()
        {
            var bullet = gameObjectBuilder
                .Physics
                .Rigidbody2D(10)
                .BoxCollider2D()
                .Transform()
                .Visual
                .Sprite(_bulletModel.Sprite)
                .Name("Bullet");           
            return bullet;
        }
    }
}
