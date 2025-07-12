using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.InputFieldBehaviors;

public class InputFieldDisplayer : Displayer<InputField>
{
    protected override string ProtectedGetDisplay(InputField component)
    {
        return $"{component.Text}: {component.Input}";
    }
}