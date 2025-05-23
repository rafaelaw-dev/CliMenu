using System.Text;
using CliMenu.Abstract.Interfaces;

namespace CliMenu.Core.Menus
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