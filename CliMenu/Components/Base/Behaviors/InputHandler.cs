using CliMenu.Interfaces;
using CliMenu.Utils;

namespace CliMenu.Components.Base.Behaviors;

/// <summary>
/// Abstract base class for input handling behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class InputHandler<TComponent> : IInputHandler
    where TComponent : IComponent
{
    /// <summary>
    /// Event fired when a key is pressed.
    /// </summary>
    public event EventHandler<SingleArgumentEventArgs<ConsoleKey>>? OnKeyPress;

    /// <summary>
    /// Handle a console key input.
    /// </summary>
    /// <param name="key">The pressed key.</param>
    protected abstract void ProtectedHandleInput(TComponent component, ConsoleKey key);

    /// <inheritdoc/>
    public void HandleInput(IComponent component, ConsoleKey key)
    {
        OnKeyPress?.Invoke(this, new SingleArgumentEventArgs<ConsoleKey>(key));
        ProtectedHandleInput((TComponent)component, key);
    }
}