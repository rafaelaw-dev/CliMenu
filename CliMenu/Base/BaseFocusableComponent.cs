using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class for components that can receive focus.
/// Inherits from <see cref="BaseComponent{TExec, TDisp, TInput}"/> and implements <see cref="IFocusable"/>.
/// </summary>
/// <typeparam name="TExec">Type of executable behavior implementing <see cref="IExecutable"/>.</typeparam>
/// <typeparam name="TDisp">Type of display behavior implementing <see cref="IDisplayer"/>.</typeparam>
/// <typeparam name="TInput">Type of input handler implementing <see cref="IInputHandler"/>.</typeparam>
public abstract class FocusableBaseComponent<TExec, TDisp, TInput>(string name)
    : BaseComponent<TExec, TDisp, TInput>(name), IFocusable
    where TExec : IExecutable
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    /// <summary>
    /// Event fired when the component gains focus.
    /// </summary>
    public event Action? OnFocus;

    /// <summary>
    /// Event fired when the component loses focus.
    /// </summary>
    public event Action? OnBlur;

    private bool isFocused;

    /// <inheritdoc/>
    public bool IsFocused
    {
        get => isFocused;
        set
        {
            isFocused = value;
            if (value) OnFocus?.Invoke();
            else OnBlur?.Invoke();
        }
    }
}