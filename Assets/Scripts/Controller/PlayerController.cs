using UnityEngine;
using UnityEngine.UI;


namespace Asteroids
{
    internal sealed class PlayerController : IExecute,IController
    {
        private float _inputHorizontal;
        private float _inputVertical;
        private bool _fire1;
        private Vector3 _direction;
        private bool _isAddAcceleration;
        private bool _isRemoveAcceleration;
        private Camera _mainCamera = Camera.main;
        private readonly Rigidbody2D _playerRB;       
        private readonly Transform _playerTransform;
        private readonly float _force;
        private readonly Ship _ship;
        private readonly Player _player;
        private readonly GameObject _bullet;
        private bool _isUnlock = true;
        private readonly WeaponProxy _weaponProxy;
        
      

        public PlayerController(PlayerCreation player,BulletModel bulletModel,EnemyModel enemyModel)
        {
            _player = player.CreatePlayer();
            _playerRB = _player.GetComponent<Rigidbody2D>();            
            _playerTransform = _player.GetComponent<Transform>();
            BulletCreation bullet = new BulletCreation(bulletModel);
            _bullet = bullet.CreateGameObject();
            _bullet.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            _bullet.gameObject.GetComponent<Rigidbody2D>().mass = 1f;
            _bullet.gameObject.tag = "Bullet";
            _force = bulletModel.Force;                   
            MoveRigidbody moveRigidbody = new MoveRigidbody(_player.Speed,_playerRB);
            RotationShip rotationRigidbody = new RotationShip(_playerTransform);
            FireShip fireShip = new FireShip(_bullet, _playerTransform, _force);
            UnLockWeapon unLockWeapon = new UnLockWeapon(_isUnlock);
           _weaponProxy = new WeaponProxy(fireShip,unLockWeapon,GameObject.FindObjectOfType<Text>());
            TakeDamageShip takeDamageShip = new TakeDamageShip(_player.Health,enemyModel.Damage);         
            _ship = new Ship(moveRigidbody, rotationRigidbody,_weaponProxy,takeDamageShip);
            _player.onTriggerEnterActionPlayer += takeDamageShip.TakeDamage;
        }

        public void Update()
        {           
            _inputHorizontal = Input.GetAxis(InputConstants.HORIZONTAL);
            _inputVertical = Input.GetAxis(InputConstants.VERTICAL);
            _fire1 = Input.GetButton(InputConstants.FIRE1);
            
            _isAddAcceleration = Input.GetKeyDown(KeyCode.LeftShift);
            _isRemoveAcceleration = Input.GetKeyUp(KeyCode.LeftShift);

            _direction = Input.mousePosition - _mainCamera.WorldToScreenPoint(_playerTransform.position);

            _ship.Move(_inputHorizontal, _inputVertical,Time.deltaTime,_playerRB);
            _ship.Rotation(_direction); 
            
            
            _weaponProxy.Fire(_fire1);

            if (_isAddAcceleration)
            {
                _ship.AddAcceleration();
            }
            if (_isRemoveAcceleration)
            {
                _ship.RemoveAcceleration();
            }        
        }                      
    }
}
