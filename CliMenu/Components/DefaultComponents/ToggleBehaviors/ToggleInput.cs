using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ToggleBehaviors;

/// <summary>
/// Defines the input behavior for a <see cref="Toggle"/> component.
/// Toggles the boolean value of the component when the Enter key is pressed.
/// </summary>
public class ToggleInput : BetterInputHandler<Toggle>
{
    /// <summary>
    /// The key that toggles the value. 
    /// </summary>
    public ConsoleKey ToggleValueKey { get; } = ConsoleKey.Enter;

    public ToggleInput()
    {
        AddKey(ToggleValueKey, toggle => toggle.Value = !toggle.Value);
    }
}
