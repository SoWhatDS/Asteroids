using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AsteroidsFactory
{
    interface IWeaponFactory 
    {
        IWeapon CreateWeapon<IWeapon>();
    }
}
