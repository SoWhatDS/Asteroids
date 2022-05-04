using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AsteroidsFactory
{
    internal sealed class Gun : IWeaponFactory
    {
        public IWeapon CreateWeapon<IWeapon>()
        {
            throw new System.NotImplementedException();
        }
    }
}
