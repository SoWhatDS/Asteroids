using UnityEngine;

namespace Asteroids.Visitors
{
    public class InfoCollision : MonoBehaviour
    {      

        public Vector3 Point { get; internal set; }
        public Vector3 Normal { get; internal set; }
        public Transform ObjCollision { get; internal set; }
        public float Damage { get; internal set; }
        public Transform Transform { get; }

      
        public InfoCollision(float damage, Vector3 dir = default, Vector3 normal = default, Transform transform = null) 
        {
            Transform = transform;
        }

        public InfoCollision(float damage)
        {
            Damage = damage;
        }
    }
}
