using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Manages the focus state for components implementing <see cref="IFocusable"/>.
/// Tracks whether the component is focused via <see cref="IsFocused"/>,
/// and notifies subscribers of focus changes through the <see cref="OnFocus"/> and <see cref="OnBlur"/> events.
/// </summary>
public class FocusManager : IFocusManager
{
    private bool isFocused;

    /// <inheritdoc/>
    public bool IsFocused
    {
        get => isFocused;
        private set
        {
            isFocused = value;
            if (value) OnFocus?.Invoke(this, EventArgs.Empty);
            else OnBlur?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Event fired when the component receives focus.
    /// </summary>
    public event EventHandler? OnFocus;

    /// <summary>
    /// Event fired when the component loses focus.
    /// </summary>
    public event EventHandler? OnBlur;

    /// <inheritdoc/>
    public void Blur() => IsFocused = false;

    /// <inheritdoc/>
    public void Focus() => IsFocused = true;
}