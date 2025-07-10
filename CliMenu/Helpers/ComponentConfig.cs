using CliMenu.Components.Behaviors;
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
    /// <summary>
    /// Gets the display behavior implementation for this component.
    /// Responsible for producing the string representation to be displayed.
    /// </summary>
    public TDisp Disp { get; }

    /// <summary>
    /// Gets the input handler implementation for this component.
    /// Responsible for handling input key events.
    /// </summary>
    public TInput Input { get; }

    /// <summary>
    /// Gets the focus manager that handles focus state and events.
    /// </summary>
    public IFocusManager FocusManager { get; }

    /// <summary>
    /// Gets the life cycle manager that controls the active/inactive state of the component.
    /// </summary>
    public ILifeCycle LifeCycle { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ComponentConfig{TDisp, TInput}"/> record.
    /// </summary>
    /// <param name="disp">The display behavior implementation. Cannot be null.</param>
    /// <param name="input">The input handler implementation. Cannot be null.</param>
    /// <param name="focusManager">Optional focus manager. If null, a new <see cref="FocusManager"/> is created.</param>
    /// <param name="lifeCycle">Optional life cycle manager. If null, a new <see cref="LifeCycle"/> is created.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="disp"/> or <paramref name="input"/> is null.</exception>
    public ComponentConfig(
        TDisp disp,
        TInput input,
        IFocusManager? focusManager = null,
        ILifeCycle? lifeCycle = null)
    {
        Disp = disp ?? throw new ArgumentNullException(nameof(disp));
        Input = input ?? throw new ArgumentNullException(nameof(input));
        FocusManager = focusManager ?? new FocusManager();
        LifeCycle = lifeCycle ?? new LifeCycle();
    }
}