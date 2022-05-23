using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ObjectPool : IDisposable 
    {
        private readonly Stack<GameObject> _stack = new Stack<GameObject>();
        private readonly GameObject _prefab;
        private readonly Transform _root;
       
       

        public ObjectPool(GameObject prefab)
        {
            _prefab = prefab;
            _root = new GameObject($"[{_prefab.name}]").transform;
        }

        public GameObject Pop()
        {
            GameObject go;
            if (_stack.Count == 0)
            {
                go = GameObject.Instantiate(_prefab);
                go.name = _prefab.name;                
                Debug.Log("POP = 0");
            }
            else 
            {
                go = _stack.Pop();
                Debug.Log("POP not empty");
            }
            go.SetActive(true);
            go.transform.SetParent(null);
            return go;
        }

        public void Push(GameObject go)
        {
            _stack.Push(go);
            go.transform.SetParent(_root);
            go.SetActive(false);
            Debug.Log("PUSH");
        }

        public void Dispose()
        {
            for (var i = 0; i < _stack.Count; i++)
            {
                var gameObject = _stack.Pop();
                GameObject.Destroy(gameObject);
            }
            GameObject.Destroy(_root.gameObject);
        }
    }
}

