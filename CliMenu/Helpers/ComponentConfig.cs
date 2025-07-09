using CliMenu.Components.Base.Behaviors;
using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Immutable configuration record that encapsulates the default behaviors for a component.
/// Contains the display behavior, input handler, life cycle manager, and focus manager.
/// Ensures that none of the provided behaviors are null by validating in the constructor.
/// </summary>
/// <typeparam name="TDisp">Type of the display behavior, must implement <see cref="IDisplayer"/>.</typeparam>
/// <typeparam name="TInput">Type of the input handler behavior, must implement <see cref="IInputHandler"/>.</typeparam>
public sealed record ComponentConfig<TDisp, TInput>
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    public TDisp Disp { get; }
    public TInput Input { get; }
    public IFocusManager FocusManager { get; }
    public ILifeCycle LifeCycle { get; }
    
    /// <summary>
    /// Immutable configuration record that encapsulates the default behaviors for a component.
    /// Contains the display behavior, input handler, life cycle manager, and focus manager.
    /// Ensures that none of the provided behaviors are null by validating in the constructor.
    /// </summary>
    /// <param name="disp">The display behavior implementation.</param>
    /// <param name="input">The input handler implementation.</param>
    /// <param name="lifeCycle">The life cycle manager controlling component activation.</param>
    /// <param name="focusManager">The focus manager controlling component focus state.</param>
    /// <exception cref="ArgumentNullException"></exception>
    public ComponentConfig(TDisp disp, TInput input, IFocusManager? focusManager = null, ILifeCycle? lifeCycle = null)
    {
        Disp = disp ?? throw new ArgumentNullException(nameof(disp));
        Input = input ?? throw new ArgumentNullException(nameof(input));
        FocusManager = focusManager ?? new FocusManager();
        LifeCycle = lifeCycle ?? new LifeCycle();
    }
}