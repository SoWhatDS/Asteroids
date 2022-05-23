

namespace Asteroids.Facade
{
    internal sealed class Map 
    {
        private Player _player;
        private Enemy _enemy;
        private int _sizeMap;

        public Map(int sizeMap, Player player,Enemy enemy,Enemy boss,Enemy immortalEnemy)
        {
            _sizeMap = sizeMap;
            _player = player;
            _enemy = enemy;
        }      

    }
}
