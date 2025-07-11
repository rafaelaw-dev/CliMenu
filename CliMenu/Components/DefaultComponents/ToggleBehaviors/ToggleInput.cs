using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ToggleBehaviors;

/// <summary>
/// Defines the input behavior for a <see cref="Toggle"/> component.
/// Toggles the boolean value of the component when the Enter key is pressed.
/// </summary>
public class ToggleInput : InputHandler<Toggle>
{
    /// <inheritdoc/>
    protected override void ProtectedHandleInput(Toggle component, ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.Enter:
                component.Value = !component.Value;
                break;
        }
    }
}
