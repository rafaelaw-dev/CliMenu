namespace CliMenu.Interfaces;

/// <summary>
/// Interface for providing display content as string.
/// </summary>
public interface IDisplayer
{
    /// <summary>
    /// Returns the string to be displayed by the component.
    /// </summary>
    /// <returns>Display string.</returns>
    string GetDisplay();
}
