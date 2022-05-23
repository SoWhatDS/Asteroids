using UnityEngine;
using System;

namespace Asteroids
{
    internal  sealed class Enemy : MonoBehaviour, IUnit, ICopyble
    {
        public float Speed { get; set; }

        public float Health { get; set; }

        public Transform Position { get; set; }

        public float Damage { get; set; }

        public GameObject Prefub { get; set; }

        public Action<GameObject> OnTriggerAction { get; set; }

        public ICopyble copy(Vector2 position)
        {
            return Instantiate(this, position,Quaternion.identity);
        }

        public void Move(Transform targetPosition, float enemySpeed)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition.position, enemySpeed * Time.deltaTime);
        }
      
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Bullet")
            {                           
                OnTriggerAction?.Invoke(transform.gameObject);             
            }
        }



    }
}
