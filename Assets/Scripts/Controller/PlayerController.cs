using UnityEngine;


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
        private readonly Rigidbody2D _playerRB;
        private readonly Rigidbody2D _bulletRB;
        private readonly Transform _playerTransform;
        private readonly float _force;
        private readonly Ship _ship;
        private Camera _mainCamera = Camera.main;
       
        
        public PlayerController(PlayerModel playerModel, Rigidbody2D playerRB,BulletModel bulletModel,Transform playerTransform)
        {           
            _bulletRB = bulletModel.BulletRB;            
            _force = bulletModel.Force;
            _playerRB = playerRB;
            _playerTransform = playerTransform;           
            MoveRigidbody moveRigidbody = new MoveRigidbody(playerModel.Speed,playerRB);
            RotationShip rotationRigidbody = new RotationShip(playerTransform);        
            FireShip fireShip = new FireShip(_bulletRB, _playerTransform, _force);
            TakeDamageShip takeDamageShip = new TakeDamageShip(playerModel.Health);         
            _ship = new Ship(moveRigidbody, rotationRigidbody,fireShip,takeDamageShip);
            
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
            _ship.Fire(_fire1);

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
