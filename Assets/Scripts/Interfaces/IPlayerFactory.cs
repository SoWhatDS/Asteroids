using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    interface IPlayerFactory 
    {
        Player CreatePlayer();
        
    }
}
