using CliMenu.Abstract.Interfaces;

namespace CliMenu.Abstract
{
    public abstract class BaseButton : Displayable, IButton
    {
        public BaseButton(IDisplayable displayable) : base(displayable) {}

        public abstract void Execute();
    }
}