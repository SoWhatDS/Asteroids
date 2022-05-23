using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AsteroidsFactory
{
    internal sealed class Enemy : IUnit
    {
        public float Hp { get; }

        public IWeaponFactory WeaponFactory { get; }

        public Vector3 Position { get; }

        public Enemy(float hp)
        { 
        
        }
    }
}
