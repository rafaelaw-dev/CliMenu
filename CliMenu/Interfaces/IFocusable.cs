namespace CliMenu.Interfaces;

/// <summary>
/// Interface defining focusable behavior.
/// </summary>
public interface IFocusable
{
    /// <summary>
    /// Gets or sets a value indicating whether the component is currently focused.
    /// </summary>
    bool IsFocused { get; set; }
}