using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ToggleBehaviors;

public class ToggleInput : InputHandler<Toggle>
{
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