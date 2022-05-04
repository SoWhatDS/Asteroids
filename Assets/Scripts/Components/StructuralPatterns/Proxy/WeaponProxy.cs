using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    internal sealed class WeaponProxy : IWeapon
    {
        private readonly IWeapon _weapon;
        private readonly UnLockWeapon _unlockWeapon;
        private readonly Text _text;

        public WeaponProxy(IWeapon weapon, UnLockWeapon unlockWeapon,Text text)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
            _text = text;
        }

        public void Fire()
        {
            _text.gameObject.SetActive(!_unlockWeapon.IsUnlock);
            if (_unlockWeapon.IsUnlock)
            {
                _weapon.Fire();
            }
            else
            {
                _text.text = "Weapon is lock";
            }
        }
    }
}

