using System.Text;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Display.Menus
{
    public class MenuDisplayer : IDisplayer
    {
        private readonly IDisplayer[][] displayers;

        public MenuDisplayer(IDisplayer[][] displayers)
        {
            this.displayers = displayers;
        }

        public void Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
        }
    }
}