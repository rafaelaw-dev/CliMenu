using CliMenu.Source.Base;
using CliMenu.Source.Components.Helpers;
using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Components.Base;

internal abstract class BaseComponent<TExecutable, TDisplayer, TInputHandler> : LifeCycle
    where TExecutable : NoExecutable, IExecutable
    where TDisplayer : NoDisplay, IDisplayer
    where TInputHandler : NoInputHandler, IInputHandler
{
    public string Name { get; private set; }

    public abstract TExecutable Executable { get; }
    public abstract TDisplayer Displayer { get; } 
    public abstract TInputHandler InputHandler { get; }

    internal BaseComponent(string name)
    {
        Name = name;
        Enable();
    }

    public string GetDisplay() => Displayer.GetDisplay();

    public void Execute() => Executable.Execute();

    public void Handler(ConsoleKey key) => InputHandler.Handle(key);
}