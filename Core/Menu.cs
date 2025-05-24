using CliMenu.Abstract;
using CliMenu.Abstract.Interfaces.Navigation;
using CliMenu.Abstract.Interfaces.Display;
using CliMenu.Abstract.Interfaces.Backend;
using CliMenu.Enums;
using CliMenu.Helpers;

namespace CliMenu.Core
{
    public class Menu : Displayer, INavigable, INavigableRow, IExecutable
    {
        private List<MenuRow> components;

        private int _selectedRow = 0;

        public int SelectedRow
        {
            get => _selectedRow;
            set => _selectedRow = Generics.LoopVariable(value, components.Count);
        }

        public Menu(List<MenuRow> components, IDisplayer displayer) : base(displayer)
        {
            this.components = components;
        }

        public void Navigation(Directions direction)
        {
            switch (direction)
            {
                case Directions.UP:
                    SelectedRow--;
                    break;

                case Directions.DOWN:
                    SelectedRow++;
                    break;
            }
        }

        public void Execute() => components[_selectedRow].Execute();
    }
}