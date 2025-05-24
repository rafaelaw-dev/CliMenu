using CliMenu.Abstract.Interfaces.Backend;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Abstract
{
    /// <summary>
    /// Base button class that wraps an IDisplayable and requires implementation of Execute().
    /// </summary>
    public abstract class BaseButton : Displayable, IExecutable
    {
        /// <summary>
        /// Constructs a button with a displayable representation.
        /// </summary>
        /// <param name="displayable">The visual representation of the button.</param>
        public BaseButton(IDisplayable displayable) : base(displayable) {}

        /// <summary>
        /// Abstract method to execute the button’s action.
        /// Must be implemented by subclasses.
        /// </summary>
        public abstract void Execute();
    }
}