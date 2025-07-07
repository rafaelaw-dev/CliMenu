using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for display behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class Displayer<TComponent>(TComponent component) : Extends<TComponent>(component), IDisplayer
    where TComponent : BaseComponent<IDisplayer, IInputHandler>
{
    /// <summary>
    /// Event fired when the component is Displayed.
    /// </summary>
    public event EventHandler? OnDisplay;

    /// <inheritdoc/>
    /// <remarks>
    /// If you are overriding this method, please call <see cref="OnDisplay"/> on it. 
    /// </remarks>
    public abstract string GetDisplay();
}