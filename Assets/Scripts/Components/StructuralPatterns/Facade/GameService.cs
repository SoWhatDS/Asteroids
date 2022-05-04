using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Facade

{
    internal sealed class GameService 
    {
        public void Start(int sizeMap, string playerName)
        {
            var player = CreatePlayer(playerName);
            var map = CreateMap(sizeMap, player);
            StartGame(map);
        }

        public void StartGame(Map map)
        {
            var game = new Game(map);
            game.Start();
        }

        private Map CreateMap(int sizeMap, Player player)
        {
            return new Map (sizeMap, player);
        }

        private Player CreatePlayer(string playerName)
        {
            return new Player(playerName);
        }
    }
}
