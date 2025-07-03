using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Base;

internal abstract class Displayer<TComponent>(TComponent component) : IDisplayer
{
    protected TComponent Component => component;
    public abstract string GetDisplay();
}
