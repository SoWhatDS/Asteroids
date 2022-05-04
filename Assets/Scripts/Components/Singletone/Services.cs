using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class Services 
    {
        private readonly Collider[] _colliderObjects;
        private readonly List<Collider> _triggerObjects;

        private static readonly Lazy<Services> _instance = 
            new Lazy<Services>( () => new Services(), 
                LazyThreadSafetyMode.ExecutionAndPublication);

        public static Services Instance => _instance.Value;

        private Services()
        { 
        
        }

        public void Test()
        {
            Debug.Log(nameof(Services));
        }

        public List<Collider> GetObjectsInRadius(Vector3 position, float radius, int layerMask = 0)
        {
            _triggerObjects.Clear();
            Collider trigger;

            var collidersCount = Physics.OverlapSphereNonAlloc(position, radius, _colliderObjects,
                layerMask);

            for (var i = 0; i < collidersCount; i++)
            {
                trigger = _colliderObjects[i];

                if (trigger != null && !_triggerObjects.Contains(trigger))
                {
                    _triggerObjects.Add(trigger);
                }    
            }

            return _triggerObjects;
        }

            
    }
}
