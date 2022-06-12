using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Startegy
{
    public sealed class RotateBehaviour : BaseBehaviour
    {
        public override void Behaviour(Transform value)
        {
            value.Rotate(Vector3.up * _speed);
        }
    }
}
