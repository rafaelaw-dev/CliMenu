using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.ButtonBehaviors;
using CliMenu.Helpers;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// Represents a clickable button component with display and input behaviors.
/// </summary>
public sealed class Button : BaseComponent<Displayer<Button>, InputHandler<Button>>
{
    /// <summary>
    /// Gets the text displayed on the button.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets the action callback executed when the button is clicked.
    /// </summary>
    public Action Callback { get; }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<Button>, InputHandler<Button>> Defaults => new(
        new ButtonDisplayer(),
        new ButtonInput()
    );

    /// <summary>
    /// Initializes a new instance of the <see cref="Button"/> class.
    /// </summary>
    /// <param name="name">
    /// Unique name identifier of the button component within its container.
    /// </param>
    /// <param name="text">
    /// The text label to display on the button.
    /// </param>
    /// <param name="callback">
    /// The action to invoke when the button is activated (clicked).
    /// </param>
    /// <param name="config">
    /// Optional custom component configuration for display and input behaviors.
    /// If not provided, default behaviors will be used.
    /// </param>
    /// <param name="enableOnStart">
    /// Indicates whether the button should be enabled immediately after construction.
    /// </param>
    public Button(
        string name,
        string text,
        Action callback,
        ComponentConfig<Displayer<Button>, InputHandler<Button>>? config = null,
        bool enableOnStart = true)
        : base(name, config, enableOnStart)
    {
        Text = text;
        Callback = callback;
    }
}