using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    interface IViewServices 
    {
        T Instantiate<T>(GameObject prefab, Vector2 position);

        void Destroy(GameObject value);
    }
}
