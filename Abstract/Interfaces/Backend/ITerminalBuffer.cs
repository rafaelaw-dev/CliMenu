namespace CliMenu.Abstract.Interfaces.Backend
{
    /// <summary>
    /// Interface representing a terminal buffer that can be updated with new text content.
    /// </summary>
    public interface ITerminalBuffer
    {
        /// <summary>
        /// Updates the terminal buffer with the provided new text.
        /// </summary>
        /// <param name="newText">The new text content to update the terminal buffer with.</param>
        void UpdateTerminal(string newText);
    }
}