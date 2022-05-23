namespace Asteroids
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, GameData gameData)
        {
            PlayerModel playerModel = new PlayerModel(gameData.Player.Sprite, gameData.Player.Health, gameData.Player.Speed, gameData.Player.Damage, gameData.Player.Position);
            BulletModel bulletModel = new BulletModel(gameData.Bullet.Sprite, gameData.Bullet.BulletRB, gameData.Bullet.Force);
            EnemyModel enemyModel = new EnemyModel(gameData.Enemy.SpriteEnemy, gameData.Enemy.HealthEnemy, gameData.Enemy.SpeedEnemy, gameData.Enemy.Damage, gameData.Enemy.Position,gameData.Enemy.Prefub);

            PlayerCreation playerCreation = new PlayerCreation(playerModel);
            EnemyCreationFabric enemyFabric = new EnemyCreationFabric(enemyModel);

            PlayerController playerController = new PlayerController(playerCreation, bulletModel,enemyModel);
            EnemyController enemyController = new EnemyController(enemyFabric);

            controllers.Add(playerController);
            controllers.Add(enemyController);            
        }
    }
}