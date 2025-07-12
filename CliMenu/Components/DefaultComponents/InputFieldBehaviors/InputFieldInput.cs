using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.InputFieldBehaviors;

public class InputFieldInput : InputHandler<InputField>
{
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