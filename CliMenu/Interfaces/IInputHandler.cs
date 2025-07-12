namespace CliMenu.Interfaces;

/// <summary>
/// Defines behavior for handling input key events for a component.
/// </summary>
public interface IInputHandler
{
    /// <summary>
    /// Processes a console key input for the specified component.
    /// </summary>
    /// <param name="component">The component receiving the input.</param>
    /// <param name="key">The console key that was pressed.</param>
    void HandleInput(IComponent component, ConsoleKeyInfo key);
}
