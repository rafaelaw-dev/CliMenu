namespace CliMenu.Interfaces
{
    public interface IMenu : IDisplayer, IInputHandler
    {
        public void Run();
        public void Exit();

        public int SelectedRow { get; set; }
        public int SelectedCollumn { get; set; }
    }
}