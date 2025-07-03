using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Base;

internal abstract class Executable<TComponent>(TComponent component) : IExecutable
{
    protected TComponent Component => component;
    public abstract void Execute();
}
