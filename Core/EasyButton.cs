using CliMenu.Abstract;
using CliMenu.Abstract.Interfaces;

namespace CliMenu.Core
{
    public class EasyButton : BaseButton
    {
        private readonly Delegate action;
        private readonly object[] args;

        public EasyButton(Delegate action, object[] args, IDisplayable displayable) : base(displayable)
        {
            this.action = action;
            this.args = args; 
        }

        public override void Execute()
        {
            action.DynamicInvoke(args);
        }
    }
}