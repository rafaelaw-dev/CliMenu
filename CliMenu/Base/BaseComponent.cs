using CliMenu.Components.Behaviours;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;
using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class representing a generic component with executable, display and input handler behaviors.
/// Implements lifecycle management via <see cref="ILifeCycle"/>.
/// </summary>
/// <typeparam name="TDisp">Type implementing <see cref="IDisplayer"/> for display behavior.</typeparam>
/// <typeparam name="TInput">Type implementing <see cref="IInputHandler"/> for input handling behavior.</typeparam>
public abstract class BaseComponent<TDisp, TInput>
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
    /// Provides the default behaviors for executable, display and input handler.
    /// Must be implemented by derived classes.
    /// </summary>
    protected abstract ComponentConfig<TDisp, TInput> Defaults { get; }

    /// <summary>
    /// Name identifier for this component.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseComponent{TDisp, TInput}"/> class.
    /// Sets up the component's name, behaviors for display and input handling, focus management, and life cycle control.
    /// If no custom behaviors are provided, default implementations are used from the <see cref="Defaults"/> property.
    /// Optionally enables the component on start if <paramref name="enableOnStart"/> is true.
    /// </summary>
    /// <param name="name">The identifier name of the component.</param>
    /// <param name="enableOnStart">Determines whether the component should be enabled immediately after construction. Defaults to true.</param>
    /// <param name="displayer">Optional custom display behavior. If null, the default display behavior is assigned.</param>
    /// <param name="inputHandler">Optional custom input handling behavior. If null, the default input handler is assigned.</param>
    /// <param name="focus">Optional focus manager. If null, the default focus manager is assigned.</param>
    /// <param name="lifeCycle">Optional life cycle manager. If null, the default life cycle manager is assigned.</param>
    public BaseComponent(
        string name,
        bool enableOnStart = true,
        TDisp? displayer = default,
        TInput? inputHandler = default,
        IFocusManager? focus = default,
        ILifeCycle? lifeCycle = default
    )
    {
        Name = name;

        Displayer = displayer ?? Defaults.Disp;
        InputHandler = inputHandler ?? Defaults.Input;
        FocusManager = focus ?? Defaults.FocusManager;
        LifeCycle = lifeCycle ?? Defaults.LifeCycle;

        if (enableOnStart) LifeCycle.Enable();
    }
    
    /// <summary>
    /// Gets the string to display for this component.
    /// </summary>
    public string GetDisplay() => Displayer.GetDisplay();

    /// <summary>
    /// Handles an input key by invoking the input handler and firing OnKeyPress event.
    /// </summary>
    /// <param name="key">The key pressed.</param>
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