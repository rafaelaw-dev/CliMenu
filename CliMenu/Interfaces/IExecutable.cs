namespace CliMenu.Interfaces;

/// <summary>
/// Represents a component that can perform an executable action.
/// </summary>
public interface IExecutable
{
    /// <summary>
    /// Executes the action defined by the implementing component.
    /// </summary>
    void Execute();
}