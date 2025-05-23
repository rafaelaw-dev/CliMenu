using CliMenu.Abstract.Interfaces;

namespace CliMenu.Abstract
{
    public abstract class Displayer : Fowarding<IDisplayer>
    {
        public Displayer(IDisplayer displayer) : base(displayer) {}

        public virtual void Display() => inner.Display();
    }
}