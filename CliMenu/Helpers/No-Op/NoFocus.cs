using CliMenu.Interfaces;

namespace CliMenu.Helpers.NoOp;

/// <summary>
/// A no-op implementation of <see cref="IFocusable"/>
/// </summary>
public sealed class NoFocus : IFocusManager, INoOp
{
    /// <inheritdoc/>
    public bool IsFocused { get => false; set { } }

    /// <inheritdoc/>
    public void Blur() { }

    /// <inheritdoc/>
    public void Focus() { }
}