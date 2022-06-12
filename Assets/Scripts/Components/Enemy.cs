using UnityEngine;
using System;
using Asteroids.Visitors;
using Asteroids.Observer.Example2;

namespace Asteroids
{
    internal  sealed class Enemy : Hit, IUnit, ICopyble,IDeath
    {
        private float _hp;

        public float Speed { get; set; }

        public float Health { get; set; }

        public Transform Position { get; set; }

        public float Damage { get; set; }

        public GameObject Prefub { get; set; }

        public Action<GameObject> OnTriggerAction { get; set; }
        
        public TextMesh textMesh { get; set; }

        public string Name { get; set; }

        public event Action<string> OnDeathChange;
    
        public override void Activate(IDealingDamage value, InfoCollision infoCollision)
        {
            value.Visit(this, infoCollision);
        }

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
