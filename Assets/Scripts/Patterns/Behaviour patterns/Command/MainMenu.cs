using UnityEngine.UI;



namespace Command
{
    public class MainMenu : ICommand
    {
        private readonly Image _mainMenu;
        private bool _isOpenMenu;

        public MainMenu(Image mainMenu, bool isOpenMenu)
        {
            _mainMenu = mainMenu;
            _isOpenMenu = isOpenMenu;
        }

        public bool Succeeded { get; private set;}

        public bool TryExecute()
        {
            if(_isOpenMenu == false)
            {
                _mainMenu.gameObject.SetActive(true);
                _isOpenMenu = true;
                Succeeded = true;
                return Succeeded;
            }       
            return Succeeded;
        }

        public void Undo()
        {
            _mainMenu.gameObject.SetActive(false);
            _isOpenMenu = false;
        }
    }
}
