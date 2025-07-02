namespace CliMenu.Source.Interface;

/// <summary>
/// Represents an interface for components that can gain or lose focus.
/// </summary>
public interface IFocusable
{
    /// <summary>
    /// Gets or sets a value indicating whether the component is currently focused.
    /// Setting this value typically triggers focus or blur behavior.
    /// </summary>
    bool IsFocused { get; set; }

    /// <summary>
    /// Called when the component gains focus.
    /// Implement this method to define custom behavior on focus.
    /// </summary>
    void OnFocus();

    /// <summary>
    /// Called when the component loses focus.
    /// Implement this method to define custom behavior on blur.
    /// </summary>
    void OnBlur();
}