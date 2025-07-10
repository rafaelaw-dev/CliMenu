namespace CliMenu.Interfaces;

/// <summary>
/// Defines behavior for providing a display string representation of a component.
/// </summary>
public interface IDisplayer
{
    /// <summary>
    /// Returns the string representation to be displayed for the specified component.
    /// </summary>
    /// <param name="component">The component instance to render.</param>
    /// <returns>A string representing the display output of the component.</returns>
    string GetDisplay(IComponent component);
}