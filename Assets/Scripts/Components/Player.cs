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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Enemy>() == true)
            {

                onTriggerEnterActionPlayer?.Invoke(collision.gameObject);

            }
        }



    }
}
