using CliMenu.Abstract.Interfaces;

namespace CliMenu.Abstract
{
    public abstract class Displayable : Fowarding<IDisplayable>
    {
        public Displayable(IDisplayable displayable) : base(displayable) {}

        public virtual string GetDisplay() => inner.GetDisplay();
    }
}