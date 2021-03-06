using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ViewServices : IViewServices
    {
        private readonly Dictionary<string, ObjectPool> _viewCache = new Dictionary<string, ObjectPool>(12);

        public T Instantiate<T>(GameObject prefab, Vector2 position)
        {
            if (!_viewCache.TryGetValue(prefab.name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                prefab.transform.position = position;
                _viewCache[prefab.name] = viewPool;
            }

            if (viewPool.Pop().TryGetComponent(out T component))
            {               
                return component;
            }

            throw new InvalidOperationException($"({typeof(T)} not found");
        }

        public void Destroy(GameObject value)
        {                
                _viewCache[value.name].Push(value);            
        }
    }
}
