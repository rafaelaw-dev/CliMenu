using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Immutable configuration record that encapsulates the default behaviors for a component.
/// Contains the display behavior, input handler, life cycle manager, and focus manager.
/// Ensures that none of the provided behaviors are null by validating in the constructor.
/// </summary>
/// <typeparam name="TDisp">Type of the display behavior, must implement <see cref="IDisplayer"/>.</typeparam>
/// <typeparam name="TInput">Type of the input handler behavior, must implement <see cref="IInputHandler"/>.</typeparam>
/// <param name="Disp">The display behavior implementation.</param>
/// <param name="Input">The input handler implementation.</param>
/// <param name="LifeCycle">The life cycle manager controlling component activation.</param>
/// <param name="FocusManager">The focus manager controlling component focus state.</param>
public sealed record ComponentConfig<TDisp, TInput>(TDisp Disp, TInput Input, ILifeCycle LifeCycle, IFocusManager FocusManager)
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    public TDisp Disp { get; } = Disp ?? throw new ArgumentNullException(nameof(Disp));
    public TInput Input { get; } = Input ?? throw new ArgumentNullException(nameof(Input));
    public ILifeCycle LifeCycle { get; } = LifeCycle ?? throw new ArgumentNullException(nameof(LifeCycle));
    public IFocusManager FocusManager { get; } = FocusManager ?? throw new ArgumentNullException(nameof(FocusManager));
}