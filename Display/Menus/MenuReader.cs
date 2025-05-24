using CliMenu.Enums;
using CliMenu.Abstract.Interfaces;

namespace CliMenu.Display.Menus
{
    public class MenuReader : IReader, IKeyInputHandler
    {
        private readonly IMenu menu;

        public MenuReader(IMenu menu)
        {
            this.menu = menu;
        }

        public void Read()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            KeyInputHandler(key.Key);
        }

        public void KeyInputHandler(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    menu.Navigation(Directions.UP);
                    break;

                case ConsoleKey.DownArrow:
                    menu.Navigation(Directions.DOWN);
                    break;

                case ConsoleKey.RightArrow:
                    menu.Navigation(Directions.RIGHT);
                    break;

                case ConsoleKey.LeftArrow:
                    menu.Navigation(Directions.LEFT);
                    break;

                case ConsoleKey.Enter:
                    menu.Execute();
                    break;
            }
        }
    }
}