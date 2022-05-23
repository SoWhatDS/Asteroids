using UnityEngine;

namespace Asteroids
{
    public class AimDecorator : IAimDecorator
    {
        public AudioClip AudioClipAim { get; }

        public float VolumeFireOnAim { get; }

        public Transform BarrelPositionAim { get; }

        public GameObject AimInstance { get; }

        public AimDecorator(AudioClip audioClipAim,float volumeFireOnAim,Transform barrelPositionAim, GameObject aimInstance)
        {
            AudioClipAim = audioClipAim;
            VolumeFireOnAim = volumeFireOnAim;
            BarrelPositionAim = barrelPositionAim;
            AimInstance = aimInstance;
        }
    }
}
