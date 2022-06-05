
namespace Asteroids.Mediator
{
    internal sealed class Controller 
    {
        private readonly View _view;
        private readonly Model _model;

        public Controller(View view, Model model)
        {
            _view = view;
            _model = model;
        }

        public void Show()
        {
            _view.Text.text = _model._hp.ToString();
        }
    }
}
