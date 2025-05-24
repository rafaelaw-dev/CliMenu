namespace CliMenu.Abstract.Interfaces.Display
{
    /// <summary>
    /// Interface for something that can be displayed (rendered) to the terminal.
    /// </summary>
    public interface IDisplayer
    {
        /// <summary>
        /// Displays content to the terminal.
        /// </summary>
        void Display();
    }
}