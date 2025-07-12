using CliMenu.Interfaces;

namespace CliMenu.Helpers.NoOp;

/// <summary>
/// A no-op implementation of <see cref="IInputHandler"/> 
/// </summary>
public sealed class NoInput : IInputHandler, INoOp
{
    /// <inheritdoc/>
    public void HandleInput(IComponent component, ConsoleKeyInfo key) { }
}