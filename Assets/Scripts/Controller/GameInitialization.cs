namespace Asteroids
{
    internal sealed class GameInitialization 
    {
        public GameInitialization(Controllers controllers, GameData gameData)
        {
            PlayerModel playerModel = new PlayerModel(gameData.Player.Sprite, gameData.Player.Health, gameData.Player.Speed);
            BulletModel bulletModel = new BulletModel(gameData.Bullet.Sprite, gameData.Bullet.BulletRB, gameData.Bullet.Force);
            EnemyModel enemyModel = new EnemyModel(gameData.Enemy.SpriteEnemy,gameData.Enemy.HealthEnemy,gameData.Enemy.SpeedEnemy,gameData.Enemy.Damage,gameData.Enemy.Position);

            PlayerCreation playerCreation = new PlayerCreation(playerModel);           
            EnemyCreationFabric enemyFabric = new EnemyCreationFabric(enemyModel);

            PlayerInitialization playerInitialization = new PlayerInitialization(playerCreation); 
            
            controllers.Add(playerInitialization);
                                    
            controllers.Add(new PlayerController(playerModel, playerInitialization.GetPlayerRigidbody2D(), bulletModel,playerInitialization.GetPlayerTransform()));
            controllers.Add(new EnemyController(playerInitialization.GetPlayerTransform(),enemyFabric));
            
        }
    }
}
