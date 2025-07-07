using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class representing a generic component with executable, display and input handler behaviors.
/// Implements lifecycle management via <see cref="ILifeCycle"/>.
/// </summary>
/// <typeparam name="TDisp">Type implementing <see cref="IDisplayer"/> for display behavior.</typeparam>
/// <typeparam name="TInput">Type implementing <see cref="IInputHandler"/> for input handling behavior.</typeparam>
public abstract class BaseComponent<TDisp, TInput> : IComponent
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    /// <summary>
    /// The display behavior of this component.
    /// </summary>
    protected TDisp Displayer { get; private set; }

    /// <summary>
    /// The input handler behavior of this component.
    /// </summary>
    protected TInput InputHandler { get; private set; }

    /// <summary>
    /// The focus behavior of this component.
    /// </summary>
    protected IFocusManager FocusManager { get; }

    /// <summary>
    /// The life cycle behaviour of this component. (Determines if it is active or not, )
    /// </summary>
    protected ILifeCycle LifeCycle { get; }

    /// <summary>
    /// Name identifier for this component.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseComponent{TDisp, TInput}"/> class.
    /// Optionally enables the component on start if <paramref name="enableOnStart"/> is true.
    /// </summary>
    /// <param name="name">The identifier name of the component.</param>
    /// <param name="config">The <see cref="ComponentConfig{TDisp, TInput}"/> configuration of the component behaviours. </param> 
    /// <param name="enableOnStart">Determines whether the component should be enabled immediately after construction. Defaults to true.</param>
    public BaseComponent(
        string name, ComponentConfig<TDisp, TInput> config, bool enableOnStart = true)
    {
        Name = name;

        Displayer = config.Disp;
        InputHandler = config.Input;
        FocusManager = config.FocusManager;
        LifeCycle = config.LifeCycle;

        if (enableOnStart) LifeCycle.Enable();
    }
    
    /// <inheritdoc/>
    public string GetDisplay() => Displayer.GetDisplay();

    /// <inheritdoc/>
    public void HandleInput(ConsoleKey key) => InputHandler.HandleInput(key);

    /// <summary>
    /// Enables the component.
    /// </summary>
    public void Enable() => LifeCycle.Enable();

    /// <summary>
    /// Disables the component.
    /// </summary>
    public void Disable() => LifeCycle.Disable();

    /// <summary>
    /// Focuses the component.
    /// </summary>
    public void Focus() => FocusManager.Focus();

    /// <summary>
    /// Blures the component. (Component looses focus.)
    /// </summary>
    public void Blur() => FocusManager.Blur();

    /// <summary>
    /// Returns a string representing this component, including its name, active state and focus state if applicable.
    /// </summary>
    public override string ToString() =>
        $"Component '{Name}', Active: {LifeCycle.IsActive}, Focused: {FocusManager.IsFocused}";
}