using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.InputFieldBehaviors;

/// <summary>
/// Defines how the <see cref="InputField"/> component is rendered on screen.
/// Displays the input field label and the current text entered by the user.
/// </summary>
public class InputFieldDisplayer : Displayer<InputField>
{
    /// <inheritdoc/>
    protected override string ProtectedGetDisplay(InputField component)
    {
        return $"{component.Text}: {component.Input}";
    }
}