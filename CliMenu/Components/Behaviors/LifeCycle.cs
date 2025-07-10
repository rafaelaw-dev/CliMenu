using CliMenu.Interfaces;

namespace CliMenu.Components.Behaviors;

/// <summary>
/// Implements the lifecycle behavior for components,
/// managing the active state and raising events on enable or disable.
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
    /// Event triggered when the component is enabled.
    /// </summary>
    public event EventHandler? OnEnable;

    /// <summary>
    /// Event triggered when the component is disabled.
    /// </summary>
    public event EventHandler? OnDisable;

    /// <inheritdoc/>
    public void Disable() => IsActive = false;

    /// <inheritdoc/>
    public void Enable() => IsActive = true;
}