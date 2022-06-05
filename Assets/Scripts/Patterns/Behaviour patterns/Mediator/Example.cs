using UnityEngine;

namespace Asteroids.Mediator
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private View _view;

        private void Awake()
        {
            new Controller( _view,new Model(100)).Show();
        }
    }
}
