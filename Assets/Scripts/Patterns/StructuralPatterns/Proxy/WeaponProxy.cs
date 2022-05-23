using UnityEngine.UI;

namespace Asteroids
{
    internal sealed class WeaponProxy : IFire
    {
        private readonly IFire _weapon;
        private readonly UnLockWeapon _unlockWeapon;
        private readonly Text _text;

        public WeaponProxy(IFire weapon, UnLockWeapon unlockWeapon,Text text)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
            _text = text;
        }

        public void Fire(bool isFire)
        {
            _text.gameObject.SetActive(!_unlockWeapon.IsUnlock);
            if (_unlockWeapon.IsUnlock)
            {
                _weapon.Fire(isFire);
            }
            else
            {
                _text.text = "Weapon is lock";
            }
        }
    }
}

