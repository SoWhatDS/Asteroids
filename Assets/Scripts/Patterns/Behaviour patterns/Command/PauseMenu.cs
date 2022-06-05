using UnityEngine.UI;

namespace Command
{
    public class PauseMenu : ICommand
    {
        private readonly Image _pauseMenu;
        private bool _isOpenPauseMenu;

        public PauseMenu(Image pauseMenu, bool isOpenPauseMenu)
        {
            _pauseMenu = pauseMenu;
            _isOpenPauseMenu = isOpenPauseMenu;
        }

        public bool Succeeded { get; private set; }

        public bool TryExecute()
        {
            if(_isOpenPauseMenu == false)
            {
                _pauseMenu.gameObject.SetActive(false);
                _pauseMenu.gameObject.SetActive(true);
                Succeeded = true;
                _isOpenPauseMenu = true;
                return Succeeded;
            }                     
            return Succeeded;
        }

        public void Undo()
        {
            if (_isOpenPauseMenu == true)
            {
                _pauseMenu.gameObject.SetActive(false);
                _isOpenPauseMenu = false;
            }           
        }
    }
}
