using UnityEngine;

namespace Asteroids.Facade

{
    internal sealed class GameService 
    {
        public void Start(int sizeMap, string playerName, float playerHp, float enemyHp, float enemyDamage,Transform enemyPosition)
        {
            var player = CreatePlayer(playerName, playerHp);
            var enemy = CreateEnemy(enemyHp,enemyDamage,enemyPosition);
            var enemyImmortal = CreateImmortalEnemy(enemyDamage,enemyPosition);
            var enemyBoss = CreateBoss(enemyPosition);
            var map = CreateMap(sizeMap, player,enemy,enemyImmortal,enemyBoss);
            StartGame(map);
        }

        public void StartGame(Map map)
        {
            var game = new Game(map);
            game.Start();
        }

        private Map CreateMap(int sizeMap, Player player,Enemy enemy,Enemy enemyBoss,Enemy immortalEnemy)
        {
            return new Map (sizeMap, player,enemy,enemyBoss,immortalEnemy);
        }

        private Player CreatePlayer(string playerName, float hp)
        {
            return new Player(playerName, hp);
        }

        private Enemy CreateEnemy(float hp,float damage, Transform position)
        {
            return new Enemy(hp,damage,position);
        }

        private Enemy CreateImmortalEnemy(float damage,Transform position)
        {           
            return CreateEnemy(1000,damage,position);
        }

        private Enemy CreateBoss(Transform position)
        {
            return CreateEnemy(1500,100,position);
        }
    }
}
