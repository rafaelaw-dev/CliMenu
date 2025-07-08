using CliMenu.Components.Base;
using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Generic base class that extends a base component while injecting new behavior types.
/// Inherits from <see cref="BaseComponent{TDisp, TInput}"/>
/// but delegates or shares logic with an existing component.
/// </summary>
/// <typeparam name="TDisp">Type implementing <see cref="IDisplayer"/> for display logic.</typeparam>
/// <typeparam name="TInput">Type implementing <see cref="IInputHandler"/> for input handling.</typeparam>
/// <typeparam name="TComponent">
/// A component to extend, constrained to
/// <see cref="BaseComponent{IDisplayer, IInputHandler}"/>.
/// </typeparam>
public abstract class ExtendsComponent<TDisp, TInput, TComponent>(TComponent baseComponent, string name, ComponentConfig<TDisp, TInput> config, bool enableOnStart = true)
    : BaseComponent<TDisp, TInput>(name, config, enableOnStart)
    where TDisp : IDisplayer
    where TInput : IInputHandler
    where TComponent : IComponent
{
    /// <summary>
    /// The base component instance being wrapped or extended.
    /// </summary>
    protected readonly TComponent component = baseComponent;
}