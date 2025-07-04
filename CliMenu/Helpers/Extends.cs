using CliMenu.Base;
using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Base class to provide access to the extended component.
/// Used as a helper for composition.
/// </summary>
/// <typeparam name="TComponent">Type of component extending <see cref="BaseComponent{IExecutable, IDisplayer, IInputHandler}"/>.</typeparam>
public abstract class Extends<TComponent>(TComponent component)
    where TComponent : BaseComponent<IExecutable, IDisplayer, IInputHandler>
{
    /// <summary>
    /// The component instance being extended.
    /// </summary>
    protected readonly TComponent component = component;
}