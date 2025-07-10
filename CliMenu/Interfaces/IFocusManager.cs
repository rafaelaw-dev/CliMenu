namespace CliMenu.Interfaces;

/// <summary>
/// Manages the focus state of a component.
/// </summary>
public interface IFocusManager
{
    /// <summary>
    /// Gets a value indicating whether the component is currently focused.
    /// </summary>
    bool IsFocused { get; }

    /// <summary>
    /// Sets focus to the component.
    /// </summary>
    void Focus();

    /// <summary>
    /// Removes focus from the component.
    /// </summary>
    void Blur();
}