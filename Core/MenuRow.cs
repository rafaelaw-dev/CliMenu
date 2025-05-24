using CliMenu.Abstract.Interfaces.Backend;
using CliMenu.Abstract;
using CliMenu.Abstract.Interfaces.Display;
using CliMenu.Abstract.Interfaces.Navigation;
using CliMenu.Enums;

namespace CliMenu.Core
{
    public class MenuRow : Displayable, INavigable, INavigableColumn, IComponent
    {
        public MenuRow(IDisplayable displayable) : base(displayable) {}

        public int SelectedRow { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SelectedCollumn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Navigation(Directions direction)
        {
            throw new NotImplementedException();
        }
    }
}