
namespace Asteroids.Facade
{
    internal sealed class Player
    {
        private string PlayerName { get; }
        private float Hp { get; }

        public Player(string playerName,float hp)
        {
            PlayerName = playerName;
            Hp = hp;
        }
    }
}
