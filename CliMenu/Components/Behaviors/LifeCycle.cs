using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Provides a base implementation for lifecycle behavior in components,
/// handling activation state and related events.
/// </summary>
public class LifeCycle : ILifeCycle
{
    private bool isActive;

    /// <inheritdoc/>
    public bool IsActive
    {
        get => isActive;
        private set
        {
            isActive = value;
            if (value) OnEnable?.Invoke(this, EventArgs.Empty);
            else OnDisable?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Event fired when the object is enabled.
    /// </summary>
    public event EventHandler? OnEnable;

    /// <summary>
    /// Event fired when the object is disabled.
    /// </summary>
    public event EventHandler? OnDisable;

    /// <inheritdoc/>
    public void Disable() => IsActive = false;

    /// <inheritdoc/>
    public void Enable() => IsActive = true;
}