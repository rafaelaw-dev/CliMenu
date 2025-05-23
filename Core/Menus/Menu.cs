using CliMenu.Interfaces;

namespace CliMenu.Core.Menus
{
    public class Menu(IButton[][] buttons, IDisplayer displayer) : IMenu
    {
        public int SelectedRow { get; set; }
        public int SelectedCollumn { get; set; }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Display() => displayer.Display();

        public void InputHandler()
        {
            throw new NotImplementedException();
        }
    }
}