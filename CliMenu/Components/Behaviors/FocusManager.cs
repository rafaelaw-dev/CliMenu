using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Represents a focus controller for components that implement <see cref="IFocusable"/>.
/// Manages the focus state <see cref="IsFocused"/>  and notifies listeners when the focus changes
/// via the <see cref="OnChangeFocus"/> event.
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
    /// Event fired when the object is focused
    /// </summary>
    public event EventHandler? OnFocus;

    /// <summary>
    /// Event fired when the object is blured (looses focus)
    /// </summary>
    public event EventHandler? OnBlur;

    /// <inheritdoc/>
    public void Blur() => IsFocused = false;

    /// <inheritdoc/>
    public void Focus() => IsFocused = true;
}