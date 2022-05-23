using UnityEngine;

namespace Asteroids
{
    interface IMufflerDecorator 
    {
       public AudioClip AudioClipMuffler { get; }
       public float VolumeFireOnMuffler { get; }
       public Transform BarrelPositionMuffler { get; }
       public GameObject MufflerInstance { get; }    

    }
}
