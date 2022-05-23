using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    interface ICopyble 
    {
        ICopyble copy(Vector2 position);
    }
}
