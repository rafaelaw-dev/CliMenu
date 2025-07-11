using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.InputFieldBehaviors;

/// <summary>
/// Handles user input for the <see cref="InputField"/> component.
/// Appends typed characters to the input value and supports basic editing via backspace.
/// </summary>
public class InputFieldInput : InputHandler<InputField>
{
    /// <inheritdoc/>
    protected override void ProtectedHandleInput(InputField component, ConsoleKeyInfo keyInfo)
    {
        var key = keyInfo.Key;

        if (key == ConsoleKey.LeftArrow)
            component.SetIndex(component.Index - 1);

        if (key == ConsoleKey.RightArrow)
            component.SetIndex(component.Index + 1);

        if (key == ConsoleKey.Backspace)
        {
            if (component.Index != 0)
            {
                component.SetIndex(component.Index - 1);
                component.Input = component.Input.Remove(component.Index, 1);
            }
        }

        if (!char.IsControl(keyInfo.KeyChar))
        {
            component.Input = component.Input.Insert(component.Index, Convert.ToString(keyInfo.KeyChar));
            component.SetIndex(component.Index + 1);
        }
    }
}