using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.ToggleBehaviors;
using CliMenu.Helpers;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// Represents a toggleable (on/off) option in the menu.
/// Can be used to represent binary settings (true/false).
/// </summary>
public sealed class Toggle : BaseComponent<Displayer<Toggle>, InputHandler<Toggle>>
{
    /// <summary>
    /// The label text shown next to the toggle.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// The current boolean state of the toggle.
    /// True means "on"/checked, false means "off"/unchecked.
    /// </summary>
    public bool Value { get; set; }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<Toggle>, InputHandler<Toggle>> Defaults => new(
        new ToggleDisplayer(),
        new ToggleInput()
    );
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Toggle"/> component.
    /// </summary>
    /// <param name="name">Unique identifier for the component.</param>
    /// <param name="text">The label to be displayed beside the toggle state.</param>
    /// <param name="initialValue">Initial value (true for on/checked, false for off/unchecked).</param>
    /// <param name="config">Optional configuration to override the default behavior.</param>
    /// <param name="enableOnStart">Whether the component should start enabled (active).</param>
    public Toggle(
        string name,
        string text,
        bool initialValue = false,
        ComponentConfig<Displayer<Toggle>, InputHandler<Toggle>>? config = null,
        bool enableOnStart = true)
        : base(name, config, enableOnStart)
    {
        Text = text;
        Value = initialValue;
    }
}