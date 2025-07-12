using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// An improved input handler that manages multiple key-to-action bindings for a specific component type.
/// </summary>
/// <typeparam name="TComponent">The type of the component this handler works with, constrained to <see cref="IComponent"/>.</typeparam>
public abstract class BetterInputHandler<TComponent> : InputHandler<TComponent>
    where TComponent : IComponent
{
    private readonly List<KeyActionBinder<TComponent>> keys = [];

    /// <summary>
    /// Adds a new key-action binding.
    /// Throws an exception if the exact key-action pair already exists.
    /// </summary>
    /// <param name="key">The console key to bind.</param>
    /// <param name="action">The action to invoke when the key is pressed. Nullable.</param>
    /// <exception cref="ArgumentException">Thrown if the key-action pair already exists.</exception>
    protected void AddKey(ConsoleKey key, Action<TComponent>? action)
    {
        if (keys.Any(k => k.Action == action && k.Key == key))
            throw new ArgumentException("This key already has this action.");

        keys.Add(new(key, action));
    }

    /// <summary>
    /// Removes an existing key-action binding.
    /// Throws an exception if the binding is not found.
    /// </summary>
    /// <param name="binder">The key-action binder to remove.</param>
    /// <exception cref="ArgumentException">Thrown if the binder does not exist in the collection.</exception>
    protected void RemoveKey(KeyActionBinder<TComponent> binder)
    {
        if (!keys.Contains(binder))
            throw new ArgumentException("The binder you selected doesn't exist");

        keys.Remove(binder);
    }

    public IEnumerable<KeyActionBinder<TComponent>> FindKeyBinder(ConsoleKey key) => 
        keys.Where(k => k.Key == key);

    public IEnumerable<KeyActionBinder<TComponent>> FindKeyBinder(Action<TComponent> action) =>
        keys.Where(k => k.Action == action);

    /// <summary>
    /// Handles the input by invoking all actions associated with the pressed key.
    /// </summary>
    /// <param name="component">The component on which to invoke the actions.</param>
    /// <param name="key">The key pressed by the user.</param>
    protected override void ProtectedHandleInput(TComponent component, ConsoleKeyInfo keyInfo)
    {
        var key = keyInfo.Key;
        foreach (var binder in keys.Where(k => k.Key == key))
            binder.Action?.Invoke(component);
    }
}