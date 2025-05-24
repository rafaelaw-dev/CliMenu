using CliMenu.Helpers;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Abstract
{
    /// <summary>
    /// Abstract base class that forwards calls to an IDisplayer instance.
    /// Can be extended or overridden to add behavior.
    /// </summary>
    public class Displayer : Forwarding<IDisplayer>
    {
        /// <summary>
        /// Initializes the Displayer with an IDisplayer to delegate to.
        /// </summary>
        /// <param name="displayer">The wrapped IDisplayer instance.</param>
        public Displayer(IDisplayer displayer) : base(displayer) {}

        /// <summary>
        /// Displays content by delegating to the inner object.
        /// Can be overridden to modify behavior.
        /// </summary>
        public virtual void Display() => inner.Display();
    }
}