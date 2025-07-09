using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.ButtonBehaviors;
using CliMenu.Helpers;

namespace CliMenu.Components.DefaultComponents;

public sealed class Button(string name, string text, Action callback, ComponentConfig<Displayer<Button>, InputHandler<Button>>? config = null, bool enableOnStart = true) 
    : BaseComponent<Displayer<Button>, InputHandler<Button>>(name, config, enableOnStart)
{
    public string Text { get; } = text;
    public Action Callback { get; } = callback;

    protected override ComponentConfig<Displayer<Button>, InputHandler<Button>> Defaults => new(
        new ButtonDisplayer(),
        new ButtonInput()
    );
}