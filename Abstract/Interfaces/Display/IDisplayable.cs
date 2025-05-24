namespace CliMenu.Abstract.Interfaces.Display
{
    /// <summary>
    /// Interface representing something that can be displayed as text.
    /// </summary>
    public interface IDisplayable
    {
        /// <summary>
        /// Returns the formatted string for display.
        /// </summary>
        /// <returns>Display text.</returns>
        string GetDisplay();
    }
}