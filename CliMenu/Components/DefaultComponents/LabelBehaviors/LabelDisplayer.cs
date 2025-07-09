using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.LabelBehaviors;

public class LabelDisplayer : Displayer<Label>
{
    protected override string ProtectedGetDisplay(Label component) => component.Text;
}