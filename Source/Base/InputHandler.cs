using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Base;

internal abstract class InputHandler<TComponent>(TComponent component) : IInputHandler
{
    protected TComponent Component => component;
    public abstract void Handle(ConsoleKey key);
}
