namespace Asteroids
{
    internal sealed class GameInitialization 
    {
        public GameInitialization(Controllers controllers, GameData gameData)
        {
            PlayerModel playerModel = new PlayerModel(gameData.Player.Sprite, gameData.Player.Health, gameData.Player.Speed);
            BulletModel bulletModel = new BulletModel(gameData.Bullet.Sprite, gameData.Bullet.BulletRB, gameData.Bullet.Force);
            EnemyModel enemyModel = new EnemyModel(gameData.Enemy.SpriteEnemy,gameData.Enemy.HealthEnemy,gameData.Enemy.SpeedEnemy,gameData.Enemy.Damage);

            PlayerCreation playerCreation = new PlayerCreation(playerModel);
            BulletCreation bulletCreation = new BulletCreation(bulletModel);

            EnemyCreationFabric enemyFabric = new EnemyCreationFabric(enemyModel);

            PlayerInitialization playerInitialization = new PlayerInitialization(playerCreation);
            BulletInitialization bulletInitialization = new BulletInitialization(bulletCreation);
            EnemyInitialization enemyInitialization = new EnemyInitialization(enemyFabric);

            controllers.Add(playerInitialization);
            controllers.Add(bulletInitialization);
            controllers.Add(enemyInitialization);   
            
            controllers.Add(new PlayerController(playerModel, playerInitialization.GetPlayerRigidbody2D(), bulletModel,playerInitialization.GetPlayerTransform()));
            controllers.Add(new EnemyController(playerInitialization.GetPlayerTransform(), enemyFabric));
            
        }
    }
}
