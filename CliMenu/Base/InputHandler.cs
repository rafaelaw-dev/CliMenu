using CliMenu.Helpers;
using CliMenu.Interfaces;
using CliMenu.Utils;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for input handling behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class InputHandler<TComponent>(TComponent component) : Extends<TComponent>(component), IInputHandler
    where TComponent : IComponent
{
    /// <summary>
    /// Event fired when a key is pressed.
    /// </summary>
    public event EventHandler<SingleArgumentEventArgs<ConsoleKey>>? OnKeyPress;

    /// <inheritdoc/>
    /// <remarks>
    /// If you are overriding this method, please call <see cref="OnKeyPress"/> on it. 
    /// </remarks>
    public abstract void HandleInput(ConsoleKey key);
}