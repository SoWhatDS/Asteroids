using UnityEngine;

namespace Asteroids.State
{
    public sealed class StateTest : MonoBehaviour
    {
        private void Start()
        {
            Player c = new Player(new ConcreateStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
