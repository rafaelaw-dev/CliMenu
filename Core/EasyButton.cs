using CliMenu.Abstract;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Core
{
    /// <summary>
    /// A button that executes a given delegate with arguments when triggered.
    /// </summary>
    public class EasyButton : BaseButton
    {
        private readonly Delegate action;
        private readonly object[] args;

        /// <summary>
        /// Creates a new EasyButton instance.
        /// </summary>
        /// <param name="action">The delegate to execute.</param>
        /// <param name="args">Arguments to pass to the delegate when executed.</param>
        /// <param name="displayable">An object that defines how the button is displayed.</param>
        public EasyButton(Delegate action, object[] args, IDisplayable displayable) : base(displayable)
        {
            this.action = action;
            this.args = args; 
        }

        /// <summary>
        /// Executes the assigned delegate with the provided arguments.
        /// </summary>
        public override void Execute()
        {
            action.DynamicInvoke(args);
        }
    }
}