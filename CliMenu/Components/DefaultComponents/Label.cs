using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.LabelBehaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// Represents a non-interactive text component to be displayed in the menu.
/// Useful for titles, instructions, or static content.
/// </summary>
public sealed class Label : BaseComponent<Displayer<Label>, NoInput>
{
    /// <summary>
    /// The text content displayed by the label.
    /// </summary>
    public string Text { get; set; }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<Label>, NoInput> Defaults => new(
        new LabelDisplayer(),
        new NoInput(),
        new NoFocus()
    );

    /// <summary>
    /// Creates a new label component with the specified name and text content.
    /// </summary>
    /// <param name="name">Unique identifier for the component.</param>
    /// <param name="text">The text to display.</param>
    /// <param name="config">Optional component configuration. If null, defaults are used.</param>
    /// <param name="enableOnStart">Whether the label is enabled when initialized.</param>
    public Label(
        string name,
        string text,
        ComponentConfig<Displayer<Label>, NoInput>? config = null,
        bool enableOnStart = true)
    : base(name, config, enableOnStart)
    {
        Text = text;
    }
}
