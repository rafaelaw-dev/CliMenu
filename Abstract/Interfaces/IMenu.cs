using CliMenu.Enums;

namespace CliMenu.Abstract.Interfaces
{
    public interface IMenu 
    {
        public int SelectedRow { get; set; }
        public int SelectedCollumn { get; set; }

        public void Navigation(Directions direction);
        public void Execute();
    }
}