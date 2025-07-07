namespace CliMenu.Interfaces;

/// <summary>
/// Interface for lifecycle management of components.
/// </summary>
public interface ILifeCycle
{
    /// <summary>
    /// Gets a value indicating whether the component is currently active.
    /// </summary>
    bool IsActive { get; }

    /// <summary>
    /// Enables the component.
    /// </summary>
    void Enable();

    /// <summary>
    /// Disables the component.
    /// </summary>
    void Disable();
}