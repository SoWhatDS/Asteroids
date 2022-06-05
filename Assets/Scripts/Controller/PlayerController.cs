using UnityEngine;
using UnityEngine.UI;
using ChainOfResponsibility.second;


namespace Asteroids
{
    internal sealed class PlayerController : IExecute,IController
    {
        private float _inputHorizontal;
        private float _inputVertical;
        private bool _addDamage;
        private bool _fire1;
        private bool _addHealth;
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
        private readonly PlayerModifier _playerModifier;
        private readonly AddDamageModifier _addDamagePlayer;
        private readonly AddHealthModifier _addHealthPlayer;
        private readonly int _maxHpPlayer = 5000;
        private readonly int _addDamageNumber = 100;



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
            _playerModifier = new PlayerModifier(_player);
            _addDamagePlayer = new AddDamageModifier(_player,_addDamageNumber);
            _addHealthPlayer = new AddHealthModifier(_player,_maxHpPlayer);
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
            _addDamage = Input.GetButton(InputConstants.AddDamage);
            _addHealth = Input.GetButton(InputConstants.AddHealth);
            
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
            if (_addDamage)
            {
                _playerModifier.Add(_addDamagePlayer);
                _playerModifier.Handle();
                Debug.Log(_player.Damage);
            }
            if (_addHealth)
            {
                _playerModifier.Add(_addHealthPlayer);
                _playerModifier.Handle();
                Debug.Log(_player.Health);
            }
        }                      
    }
}
