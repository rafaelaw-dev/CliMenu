using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ButtonBehaviors;

/// <summary>
/// Input handler for the <see cref="Button"/> component.
/// Handles key presses and triggers a click event when Enter or Space is pressed.
/// </summary>
public class ButtonInput : BetterInputHandler<Button>
{
    /// <summary>
    /// The key that activates the button's callback.
    /// </summary>
    public ConsoleKey CallbackKey { get; } = ConsoleKey.Enter;

    public ButtonInput()
    {
        AddKey(CallbackKey, button => button.Callback());
    }
}