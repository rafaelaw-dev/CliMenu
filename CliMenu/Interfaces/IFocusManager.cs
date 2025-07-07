namespace CliMenu.Interfaces;

/// <summary>
/// Interface defining Focus Manager behaviour.
/// </summary>
public interface IFocusManager
{
    /// <summary>
    /// Gets or sets a value indicating whether the component is currently focused.
    /// </summary>
    bool IsFocused { get; }

    /// <summary>
    /// Sets <see cref="IsFocused"/> to true and has aditional logic.
    /// </summary>
    void Focus();

    /// <summary>
    /// Sets <see cref="IsFocused"/> to false and has aditional logic.
    /// </summary>
    void Blur();
}