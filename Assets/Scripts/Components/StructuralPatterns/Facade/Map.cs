

namespace Asteroids.Facade
{
    internal sealed class Map 
    {
        private Player _player;
        private int _sizeMap;

        public Map(int sizeMap, Player player)
        {
            _sizeMap = sizeMap;
            _player = player;
        }      

    }
}
