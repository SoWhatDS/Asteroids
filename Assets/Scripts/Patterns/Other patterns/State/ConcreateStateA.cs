namespace Asteroids.State
{
    public sealed class ConcreateStateA : State
    {
        public override void Handle(Player player)
        {
            if (player.Health <= 0)
            {
                player.State = new ConcreateStateA();
            }
        }
    }
}
