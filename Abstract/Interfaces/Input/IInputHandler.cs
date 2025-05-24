namespace CliMenu.Abstract.Interfaces.Input
{
    /// <summary>
    /// Interface for handling string input.
    /// </summary>
    public interface IInputHandler
    {
        /// <summary>
        /// Processes the input string.
        /// </summary>
        /// <param name="input">Input text.</param>
        void InputHandler(string input);
    }
}
