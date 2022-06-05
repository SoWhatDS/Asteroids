using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Command
{
    internal sealed class InputHandler : MonoBehaviour
    {
        [SerializeField] private Transform _box;
        [SerializeField] private Image  _mainMenu;
        [SerializeField] private Image _pauseMenu;
        [SerializeField] private float _moveDistance;
        [SerializeField] private bool _isOpenMainMenu;
        [SerializeField] private bool _isOpenPauseMenu;
        private ICommand _buttonW;
        private ICommand _buttonS;
        private ICommand _buttonA;
        private ICommand _buttonD;
        private ICommand _buttonB;
        private ICommand _buttonZ;
        private ICommand _buttonESC;
        private ICommand _buttonSpace;
        private readonly List<ICommand> _oldCommands = new List<ICommand>();

        private void Start()
        {
            _buttonW = new MoveForward(_moveDistance, _box);
            _buttonS = new MoveReverse(_moveDistance, _box);
            _buttonA = new MoveLeft(_moveDistance,_box);
            _buttonD = new MoveRight(_moveDistance, _box);
            _buttonESC = new MainMenu(_mainMenu,_isOpenMainMenu);
            _buttonSpace = new PauseMenu(_pauseMenu, _isOpenPauseMenu);
            _buttonZ = new UndoCommand(_oldCommands);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (_buttonA.TryExecute())
                {
                    _oldCommands.Add(_buttonA);
                }
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                if (_buttonB.TryExecute())
                {
                    _oldCommands.Add(_buttonB);
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (_buttonD.TryExecute())
                {
                    _oldCommands.Add(_buttonD);
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (_buttonS.TryExecute())
                {
                    _oldCommands.Add(_buttonS);
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                if (_buttonW.TryExecute())
                {
                    _oldCommands.Add(_buttonW);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_buttonESC.TryExecute())
                {
                    _oldCommands.Add(_buttonESC);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_buttonSpace.TryExecute())
                {
                    _oldCommands.Add(_buttonSpace);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                _buttonZ.TryExecute();
            }
        }
    }
}
