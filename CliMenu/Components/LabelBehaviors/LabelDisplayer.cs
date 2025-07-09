using CliMenu.Components.Behaviors;

namespace CliMenu.Components.LabelBehaviors;

public class LabelDisplayer : Displayer<Label>
{
    protected override string ProtectedGetDisplay(Label component) => component.Text;
}