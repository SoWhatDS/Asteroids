using Asteroids;

namespace Asteroids.State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Player player)
        {
            if (player.Health > 0)
            {
                player.State = new ConcreteStateB();
            }           
        }
    }
}
