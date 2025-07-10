namespace CliMenu.Interfaces;

/// <summary>
/// Defines the lifecycle management behavior of a component,
/// controlling its active state.
/// </summary>
public interface ILifeCycle
{
    /// <summary>
    /// Gets a value indicating whether the component is currently active/enabled.
    /// </summary>
    bool IsActive { get; }

    /// <summary>
    /// Activates or enables the component.
    /// </summary>
    void Enable();

    /// <summary>
    /// Deactivates or disables the component.
    /// </summary>
    void Disable();
}
