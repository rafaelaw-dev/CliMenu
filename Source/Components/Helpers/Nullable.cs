using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Components.Helpers;

internal class NoExecutable : IExecutable
{
    public void Execute() { }
}

internal record NoDisplay : IDisplayer
{
    public string GetDisplay() { throw new NotSupportedException("This component does not support display."); }
} 

internal record NoInputHandler : IInputHandler
{
    public void Handle(ConsoleKey key) { }
}