using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Controllers : IExecute
    {
       
        private readonly List<IExecute> _executeControllers;

        internal Controllers()
        {           
            _executeControllers = new List<IExecute>();
        }

        internal Controllers Add(IController controller)
        {         
            if (controller is IExecute executeControllers)
            {
                _executeControllers.Add(executeControllers);
            }
            return this;
        }

        public void Update()
        {
            for (int i = 0; i < _executeControllers.Count; i++)
            {
                _executeControllers[i].Update();
                
            }
        }
       
    }
}
