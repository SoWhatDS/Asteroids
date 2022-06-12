using System;
using UnityEngine;

namespace Asteroids.TryParse
{

    public sealed class Example 
    {
        public int DoThomething(string input)
        {
            int ret;
            Exception exception = DoThomethingImpl(input, out ret);
            if (exception != null)
            {
                throw exception;
            }
            return ret;
        }

        public bool TrySomething(string input, out int ret)
        {
            Exception exception = DoThomethingImpl(input, out ret);
            return exception == null;
        }

        private Exception DoThomethingImpl(string input, out int ret)
        {
            ret = 0;
            if (input != "bad")
            {
                ret = 5;
                return null;
            }
            else 
            {
                return new ArgumentException("Some details");
            }
        }
    }

    internal class MyClass : MonoBehaviour
    {
        private void NameMethod()
        {
            var component = gameObject.GetComponent<Rigidbody>();
            component.AddForce(Vector3.zero * 999.0f);

            if (gameObject.TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbody.AddForce(Vector3.zero * 999.0f);
            }

            if(int.TryParse("ololo", out int y))
            {
                Debug.Log(y);
            }
        }
    }
}
