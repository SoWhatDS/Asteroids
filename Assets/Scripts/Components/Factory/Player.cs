using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AsteroidsFactory
{
    internal sealed class Player : IUnit
    {
        public float Hp { get; }

        public IWeaponFactory WeaponFactory { get; }

        public Vector3 Position { get; }

        public Player(float hp,IWeaponFactory weaponFactory, Vector3 position)
        {
            Hp = hp;
            WeaponFactory = weaponFactory;
            Position = position;
        }
    }
}
