
namespace Asteroids.Iterator
{
    internal interface IAbility 
    {
        public string Name { get; }
        public int Damage { get; }
        public Target Target { get; }
        public DamageType DamageType { get; }
    }
}
