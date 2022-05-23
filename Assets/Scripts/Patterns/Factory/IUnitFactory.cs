using UnityEngine;

namespace AsteroidsFactory
{
    internal interface IUnitFactory 
    {
        IUnit CreatePlayer(float hp, Vector3 position);
        IUnit CreatePlayerImmortal(Vector3 position);
        IUnit CreateEnemy(float hp);
        IUnit CreatePlayerInStartPosition(float hp);

    }
}
