using Asteroids;


namespace ChainOfResponsibility.second
{
    internal sealed class AddDamageModifier : PlayerModifier
    {
        private readonly int _damage;

        public AddDamageModifier(Player player, int damage) : base(player)
        {
            _damage = damage;
        }

        public override void Handle()
        { 
            _player.Damage += _damage;
            base.Handle();
        }

    }
}
