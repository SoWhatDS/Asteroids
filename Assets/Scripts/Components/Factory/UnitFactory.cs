using System;
using UnityEngine;

namespace AsteroidsFactory
{
    internal sealed class UnitFactory : IUnitFactory
    {
        private readonly IWeaponFactory _weaponFactory;

        public UnitFactory(IWeaponFactory weaponFactory)
        {
            _weaponFactory = weaponFactory;
        }

        public IUnit CreateEnemy(float hp)
        {
            return new Enemy(hp);
        }

        public IUnit CreatePlayer(float hp, Vector3 position)
        {
            return new Player(hp, _weaponFactory.CreateWeapon<Gun>(), position);
        }

        public IUnit CreatePlayerImmortal(Vector3 position)
        {
            return CreatePlayer(Single.MaxValue, position);
        }

        public IUnit CreatePlayerInStartPosition(float hp)
        {
            return CreatePlayer(hp, Vector3.zero);
        }
    }
}
