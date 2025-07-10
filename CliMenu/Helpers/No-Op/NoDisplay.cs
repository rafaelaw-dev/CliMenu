using CliMenu.Interfaces;

namespace CliMenu.Helpers.NoOp; 

/// <summary>
/// A no-op implementation of <see cref="IDisplayer"/>
/// </summary>
public sealed record NoDisplay : IDisplayer, INoOp
{
    /// <inheritdoc/>
    public string GetDisplay(IComponent component) => "<NoDisplay>";
}