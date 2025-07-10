using CliMenu.Components.Base;
using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Abstract base class for components that extend or wrap another component.
/// Provides a way to add or override behaviors of an existing component of type <typeparamref name="TComponent"/>.
/// </summary>
/// <typeparam name="TDisp">Type of the display behavior, must implement <see cref="IDisplayer"/>.</typeparam>
/// <typeparam name="TInput">Type of the input handler behavior, must implement <see cref="IInputHandler"/>.</typeparam>
/// <typeparam name="TComponent">Type of the component being extended or wrapped, must implement <see cref="IComponent"/>.</typeparam>
public abstract class ExtendsComponent<TDisp, TInput, TComponent> : BaseComponent<TDisp, TInput>
    where TDisp : IDisplayer
    where TInput : IInputHandler
    where TComponent : IComponent
{
    /// <summary>
    /// The base component instance that is wrapped or extended by this component.
    /// Use this to delegate or override behavior as needed.
    /// </summary>
    protected readonly TComponent component;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExtendsComponent{TDisp, TInput, TComponent}"/> class.
    /// </summary>
    /// <param name="name">The unique name of the extended component.</param>
    /// <param name="component">The base component instance to extend or wrap.</param>
    /// <param name="config">Optional configuration for display and input behaviors. If null, defaults are used.</param>
    /// <param name="enableOnStart">Whether the component should start enabled (active).</param>
    protected ExtendsComponent(
        string name,
        TComponent component,
        ComponentConfig<TDisp, TInput>? config = null,
        bool enableOnStart = true)
        : base(name, config, enableOnStart)
    {
        this.component = component ?? throw new ArgumentNullException(nameof(component));
    }
}
