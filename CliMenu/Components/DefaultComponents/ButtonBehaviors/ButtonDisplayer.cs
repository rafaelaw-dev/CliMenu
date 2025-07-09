using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.ButtonBehaviors;

public class ButtonDisplayer : Displayer<Button>
{
    protected override string ProtectedGetDisplay(Button component) => $"[{component.Text}]";
}
