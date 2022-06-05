using Asteroids;


namespace ChainOfResponsibility.second
{
    internal sealed class AddHealthModifier : PlayerModifier
    {

        private readonly int _maxHp = 5000;

        public AddHealthModifier(Player player, int maxHp) : base(player)
        {
            _maxHp = maxHp;
        }

        public override void Handle()
        {
            if (_player.Health <= _maxHp)
            {
                _player.Health += 100;
            }
            base.Handle();
        }

    }
}
