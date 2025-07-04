using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for display behavior of a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class Displayer<TComponent>(TComponent component) : Extends<TComponent>(component), IDisplayer
    where TComponent : BaseComponent<IExecutable, IDisplayer, IInputHandler>
{
    /// <summary>
    /// The component associated with this display behavior.
    /// </summary>
    protected TComponent Component => component;

    /// <summary>
    /// Gets the string representation to display for the component.
    /// </summary>
    public abstract string GetDisplay();
}