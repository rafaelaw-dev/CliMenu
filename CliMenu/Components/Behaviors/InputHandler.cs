using CliMenu.Interfaces;
using CliMenu.Utils;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Abstract base class for handling input behavior of a component.
/// </summary>
/// <typeparam name="TComponent">The type of component this input handler operates on, constrained to <see cref="IComponent"/>.</typeparam>
public abstract class InputHandler<TComponent> : IInputHandler
    where TComponent : IComponent
{
    /// <summary>
    /// Event triggered when a key is pressed.
    /// Subscribers can listen to key press events with the pressed key as argument.
    /// </summary>
    public event EventHandler<SingleArgumentEventArgs<ConsoleKey>>? OnKeyPress;

    /// <summary>
    /// Handles the input key for the specific component.
    /// Override this method to implement custom input behavior.
    /// </summary>
    /// <param name="component">The component receiving the input.</param>
    /// <param name="key">The key that was pressed.</param>
    protected abstract void ProtectedHandleInput(TComponent component, ConsoleKey key);

    /// <inheritdoc/>
    public void HandleInput(IComponent component, ConsoleKey key)
    {
        OnKeyPress?.Invoke(this, new SingleArgumentEventArgs<ConsoleKey>(key));
        ProtectedHandleInput((TComponent)component, key);
    }
}