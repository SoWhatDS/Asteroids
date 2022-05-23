using UnityEngine;

namespace Asteroids
{
    public class MufflerDecorator : IMufflerDecorator
    {
        public AudioClip AudioClipMuffler { get; }

        public float VolumeFireOnMuffler { get; }

        public Transform BarrelPositionMuffler { get; }

        public GameObject MufflerInstance { get; }

        public MufflerDecorator(AudioClip audioClipMuffler, float volumeFireOnMuffler, Transform barrelPositionMuffler, GameObject mufflerInstance)
        {
            AudioClipMuffler = audioClipMuffler;
            VolumeFireOnMuffler = volumeFireOnMuffler;
            BarrelPositionMuffler = barrelPositionMuffler;
            MufflerInstance = mufflerInstance;
        }
    }
}
