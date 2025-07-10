using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.LabelBehaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components.DefaultComponents;

public sealed class Label : BaseComponent<Displayer<Label>, NoInput>
{
    public string Text { get; set; }

    protected override ComponentConfig<Displayer<Label>, NoInput> Defaults => new(
        new LabelDisplayer(),
        new NoInput(),
        new NoFocus()
    );

    public Label(
        string name,
        string text,
        ComponentConfig<Displayer<Label>, NoInput> config,
        bool enableOnStart) 
    : base(name, config, enableOnStart)
    {
        Text = text;
    }
}