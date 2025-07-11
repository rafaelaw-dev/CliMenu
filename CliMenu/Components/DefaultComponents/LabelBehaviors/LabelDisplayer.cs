using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.LabelBehaviors;

/// <summary>
/// Displayer implementation for a <see cref="Label"/> component.
/// Simply returns the label's text for display.
/// </summary>
public class LabelDisplayer : Displayer<Label>
{
    /// <inheritdoc/>
    protected override string ProtectedGetDisplay(Label component) => component.Text;
}