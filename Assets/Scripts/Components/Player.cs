using System;
using UnityEngine;

namespace Asteroids
{
    public class Player : MonoBehaviour
    {
        public float Speed { get; set; }

        public float Health { get; set; }

        public Vector2 Position { get; set; }

        public float Damage { get; set; }

        public Action<GameObject> onTriggerEnterActionPlayer {get; set;}

        public State.State _state;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Enemy>() == true)
            {

                onTriggerEnterActionPlayer?.Invoke(collision.gameObject);

            }
        }

        public Player(State.State state)
        {
            State = state;
        }

        public State.State State
        {
            set
            {
                _state = value;
                Debug.Log("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }

    }
}
