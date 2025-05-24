namespace CliMenu.Abstract.Interfaces.Input
{
    /// <summary>
    /// Interface for handling keyboard key inputs.
    /// </summary>
    public interface IKeyInputHandler
    {
        /// <summary>
        /// Called when a key input is received.
        /// </summary>
        /// <param name="key">The pressed key.</param>
        void KeyInputHandler(ConsoleKey key);
    }
}
