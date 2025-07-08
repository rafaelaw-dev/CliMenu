using CliMenu.Helpers;
using CliMenu.Interfaces;
using CliMenu.Utils;

namespace CliMenu.Components.Base.Behaviors;

/// <summary>
/// Abstract base class for display behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="IComponent"/>.</typeparam>
public abstract class Displayer<TComponent> : IDisplayer
    where TComponent : IComponent
{
    /// <summary>
    /// Event fired when the component is Displayed.
    /// </summary>
    public event EventHandler? OnDisplay;

    /// <summary>
    /// Returns the string to be displayed by the component.
    /// </summary>
    /// <returns>Display string.</returns>
    protected abstract string ProtectedGetDisplay(TComponent component);

    /// <inheritdoc/>
    public string GetDisplay(IComponent component)
    {
        OnDisplay?.Invoke(this, EventArgs.Empty);
        return ProtectedGetDisplay((TComponent)component);
    }
}