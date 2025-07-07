using CliMenu.Base;
using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Base class to provide access to the extended component.
/// Used as a helper for composition.
/// If you want a <see cref="BaseComponent{TDisp, TInput}"/> instance, use
/// <see cref="ExtendsComponent{TDisp, TInput, TComponent}"/>.
/// </summary>
/// <typeparam name="TComponent">Type of component extending 
/// <see cref="BaseComponent{IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class Extends<TComponent>(TComponent component)
    where TComponent : IComponent
{
    /// <summary>
    /// The component instance being extended.
    /// </summary>
    protected readonly TComponent component = component;
}