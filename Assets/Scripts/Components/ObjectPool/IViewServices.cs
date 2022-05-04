using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    interface IViewServices 
    {
        T Instantiate<T>(GameObject prefab);

        void Destroy(GameObject value);
    }
}
