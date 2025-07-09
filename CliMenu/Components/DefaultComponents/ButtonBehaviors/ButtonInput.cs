using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ButtonBehaviors;

public class ButtonInput : InputHandler<Button>
{
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