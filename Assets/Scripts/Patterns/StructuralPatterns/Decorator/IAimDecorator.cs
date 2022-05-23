using UnityEngine;

namespace Asteroids
{
    interface IAimDecorator 
    {
        public AudioClip AudioClipAim { get; }
        public float VolumeFireOnAim { get; }
        public Transform BarrelPositionAim { get; }
        public GameObject AimInstance { get; }
    }
}
