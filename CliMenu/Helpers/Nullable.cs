using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// A no-op implementation of <see cref="IExecutable"/> that performs no action.
/// </summary>
public sealed record NoExecutable : IExecutable
{
    /// <inheritdoc/>
    public void Execute() { }
}

/// <summary>
/// A no-op implementation of <see cref="IDisplayer"/> that throws when display is requested.
/// </summary>
public sealed record NoDisplay : IDisplayer
{
    /// <inheritdoc/>
    public string GetDisplay() => "<NoDisplay>";
}

/// <summary>
/// A no-op implementation of <see cref="IInputHandler"/> that ignores input.
/// </summary>
public sealed record NoInput : IInputHandler
{
    /// <inheritdoc/>
    public void HandleInput(ConsoleKey key) { }
}