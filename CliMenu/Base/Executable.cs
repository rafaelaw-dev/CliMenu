using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for executable behavior attached to a component.
/// </summary>
/// <typeparam name="TComponent">Type of component, constrained to <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class Executable<TComponent>(TComponent component) : Extends<TComponent>(component), IExecutable
    where TComponent : BaseComponent<IExecutable, IDisplayer, IInputHandler>
{
    /// <summary>
    /// Reference to the component this executable belongs to.
    /// </summary>
    protected TComponent Component => component;

    /// <summary>
    /// Executes the defined action for this component.
    /// </summary>
    public abstract void Execute();
}
