using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Asteroids.NullObject
{
    internal sealed class NullObjectTest : MonoBehaviour,ITest
    {
        public event Action Doing = () => { };

        private void Start()
        {
            if (Doing != null) Doing.Invoke();
            // пример в паттерне команда класс DoNothing
            InjectDependency(new NullObjectTest());
        }

        private void InjectDependency(ITest test)
        { 
        
        }
    }

    internal interface ITest
    { 
    
    }

    internal class Test : ITest 
    { 
    
    }

    internal class TestNullObject : ITest 
    { 
    
    }

    internal class Player : MonoBehaviour
    {
        private int _hp;

        public event Action IsDeath = () => { };

        private void Update()
        {
            if (_hp <= 0)
            {
                IsDeath.Invoke();
            }
        }

        internal class Display
        {
            public Display(Player player)
            {
                player.IsDeath += PlayerOnIsDeath;
            }

            private void PlayerOnIsDeath()
            { 
               ///
            }
        }

    }
}
