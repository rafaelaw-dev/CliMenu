using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ButtonBehaviors;

/// <summary>
/// Displayer implementation for a <see cref="Button"/> component.
/// Renders the button text enclosed in square brackets.
/// </summary>
public class ButtonDisplayer : Displayer<Button>
{
    /// <inheritdoc/>
    protected override string ProtectedGetDisplay(Button component) => $"[{component.Text}]";
}
