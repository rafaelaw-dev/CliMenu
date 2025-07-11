using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ToggleBehaviors;

/// <summary>
/// Defines the display behavior for a <see cref="Toggle"/> component.
/// </summary>
public class ToggleDisplayer : Displayer<Toggle>
{
    /// <inheritdoc/>
    protected override string ProtectedGetDisplay(Toggle component)
    {
        string symbol = component.Value ? "[x]" : "[ ]";

        return $"{symbol} {component.Text}";
    }
}