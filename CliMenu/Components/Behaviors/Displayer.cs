using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Represents the abstract base class for display behavior of a component.
/// </summary>
/// <typeparam name="TComponent">The type of component this displayer is responsible for rendering.</typeparam>
public abstract class Displayer<TComponent> : IDisplayer
    where TComponent : IComponent
{
    /// <summary>
    /// Event that is triggered whenever the component is displayed.
    /// </summary>
    public event EventHandler? OnDisplay;

    /// <summary>
    /// Returns the string representation to display the component.
    /// Must be overridden by derived classes to define specific rendering logic.
    /// </summary>
    /// <param name="component">The component instance to be rendered.</param>
    /// <returns>The string to display for the given component.</returns>
    protected abstract string ProtectedGetDisplay(TComponent component);

    /// <inheritdoc/>
    public string GetDisplay(IComponent component)
    {
        OnDisplay?.Invoke(this, EventArgs.Empty);
        return ProtectedGetDisplay((TComponent)component);
    }
}