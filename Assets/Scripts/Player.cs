
using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bulletRB;
        [SerializeField] private Transform _barrel;
        [SerializeField] private Rigidbody2D _barrelRB;
        [SerializeField] private float _force;
        private Camera _mainCamera;              
        private Ship _ship;

        

        private void Awake()
        {
            _mainCamera = Camera.main;
            var moveTransform = new AccelerationMove(_speed,_barrel,_acceleration,_barrelRB);
            var rotation = new RotationShip(transform);
            var fire = new FireShip(_bulletRB,_barrel,_force);
            var takeDamage = new TakeDamageShip(_hp);
            _ship = new Ship(moveTransform,rotation,fire,takeDamage);
            
        }

        private void Update()
        {
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime,_barrelRB);
            _ship.Fire(Input.GetButton("Fire1"));

            var direction = Input.mousePosition - _mainCamera.WorldToScreenPoint(transform.position);            
            _ship.Rotation(direction);


            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {              
               _ship.RemoveAcceleration();               
            }                        
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _ship.TakeDamage(other.gameObject);
        }

        


    }
}
