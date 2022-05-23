
namespace Asteroids
{
    internal abstract class ModificationWeapon : IFireDecorator
    {
        private WeaponDecorator _weapon;

        protected abstract WeaponDecorator AddModification(WeaponDecorator weapon);

        protected abstract WeaponDecorator RemoveModification(WeaponDecorator weapon);

        public void ApplyModification(WeaponDecorator weapon)
        {
            _weapon = AddModification(weapon);
        }

        public void DeleteModification(WeaponDecorator weapon)
        {
            _weapon = RemoveModification(weapon);
        }

        public void FireDecorator()
        {
            _weapon.FireDecorator();
        }
    }
}
