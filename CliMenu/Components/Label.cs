using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.LabelBehaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components;

public sealed class Label(string name, string text, ComponentConfig<Displayer<Label>, NoInput>? config = null, bool enableOnStart = true) : BaseComponent<Displayer<Label>, NoInput>(name, config, enableOnStart)
{
    public string Text { get; set; } = text;

    protected override ComponentConfig<Displayer<Label>, NoInput> Defaults => new(new LabelDisplayer(), new NoInput(), new NoFocus());
}