namespace CliMenu.Interfaces;

/// <summary>
/// Interface for handling input keys.
/// </summary>
public interface IInputHandler
{
    /// <summary>
    /// Handle a console key input.
    /// </summary>
    /// <param name="key">The key pressed.</param>
    void HandleInput(ConsoleKey key);
}
