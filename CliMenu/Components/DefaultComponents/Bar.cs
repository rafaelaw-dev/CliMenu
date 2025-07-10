using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components.DefaultComponents;

public sealed class Bar : BaseComponent<Displayer<Bar>, NoInput>
{
    protected override ComponentConfig<Displayer<Bar>, NoInput> Defaults => throw new NotImplementedException();
    
    public Bar(string name, ComponentConfig<Displayer<Bar>, NoInput>? config = null, bool enableOnStart = true) : base(name, config, enableOnStart)
    {
    }
}