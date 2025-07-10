using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ToggleBehaviors;

public class ToggleDisplayer : Displayer<Toggle>
{
    protected override string ProtectedGetDisplay(Toggle component)
    {
        string symbol = component.Value ? "[x]" : "[ ]";

        return $"{symbol} {component.Text}";
    }
}