using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for input handling behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class InputHandler<TComponent>(TComponent component) : Extends<TComponent>(component), IInputHandler
    where TComponent : BaseComponent<IExecutable, IDisplayer, IInputHandler>
{
    /// <summary>
    /// Handles input key presses.
    /// </summary>
    /// <param name="key">The console key pressed.</param>
    public abstract void HandleInput(ConsoleKey key);
}