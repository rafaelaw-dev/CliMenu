using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ButtonBehaviors;

/// <summary>
/// Input handler for the <see cref="Button"/> component.
/// Handles key presses and triggers a click event when Enter or Space is pressed.
/// </summary>
public class ButtonInput : InputHandler<Button>
{
    /// <inheritdoc/>
    protected override void ProtectedHandleInput(Button component, ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.Enter:
                component.Callback();
                break;
        }
    }
}