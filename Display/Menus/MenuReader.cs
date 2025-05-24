using CliMenu.Enums;
using CliMenu.Abstract.Interfaces.Input;
using CliMenu.Abstract.Interfaces.Navigation;
using CliMenu.Abstract.Interfaces.Backend;

namespace CliMenu.Display.Menus
{
    public class MenuReader : IReader, IKeyInputHandler
    {
        private readonly INavigable navigable;
        private readonly IExecutable executable;

        public MenuReader(INavigable navigable, IExecutable executable)
        {
            this.navigable = navigable;
            this.executable = executable;
        }

        public void Read()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            KeyInputHandler(key.Key);
        }

        public virtual void KeyInputHandler(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    navigable.Navigation(Directions.UP);
                    break;

                case ConsoleKey.DownArrow:
                    navigable.Navigation(Directions.DOWN);
                    break;

                case ConsoleKey.RightArrow:
                    navigable.Navigation(Directions.RIGHT);
                    break;

                case ConsoleKey.LeftArrow:
                    navigable.Navigation(Directions.LEFT);
                    break;

                case ConsoleKey.Enter:
                    executable.Execute();
                    break;
            }
        }
    }
}