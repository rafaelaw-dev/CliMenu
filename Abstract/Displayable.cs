using CliMenu.Helpers;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Abstract
{
    /// <summary>
    /// Abstract base class that forwards calls to an IDisplayable instance.
    /// Can be extended or overridden to add behavior.
    /// </summary>
    public class Displayable : Forwarding<IDisplayable>
    {
        /// <summary>
        /// Initializes the Displayable with an IDisplayable to delegate to.
        /// </summary>
        /// <param name="displayable">The wrapped IDisplayable instance.</param>
        public Displayable(IDisplayable displayable) : base(displayable) {}

        /// <summary>
        /// Gets the display string by delegating to the inner object.
        /// Can be overridden to modify behavior.
        /// </summary>
        /// <returns>Display string.</returns>
        public virtual string GetDisplay() => inner.GetDisplay();
    }
}