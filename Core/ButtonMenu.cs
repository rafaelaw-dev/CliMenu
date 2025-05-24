using CliMenu.Abstract;
using CliMenu.Abstract.Interfaces;
using CliMenu.Enums;
using CliMenu.Helpers;

namespace CliMenu.Core
{
    public class ButtonMenu : Displayer, IMenu
    {
        private readonly IButton[][] buttons;

        private int _selectedRow = 0;
        private int _selectedCollumn = 0;

        public int SelectedRow
        {
            get => _selectedRow;
            set => _selectedRow = Generics.LoopVariable(value, buttons.Length);
        }

        public int SelectedCollumn
        {
            get => _selectedCollumn;
            set => _selectedCollumn = Generics.LoopVariable(value, buttons[0].Length);
        }

        public ButtonMenu(IButton[][] buttons, IDisplayer displayer) : base(displayer)
        {
            this.buttons = buttons;
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

                case Directions.LEFT:
                    SelectedCollumn--;
                    break;

                case Directions.RIGHT:
                    SelectedCollumn++;
                    break;
            }
        }

        public void Execute() => buttons[_selectedRow][_selectedCollumn].Execute();
    }
}