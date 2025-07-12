using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.InputFieldBehaviors;
using CliMenu.Helpers;

namespace CliMenu.Components.DefaultComponents;

public sealed class InputField : BaseComponent<Displayer<InputField>, InputHandler<InputField>>
{
    public string Text { get; }
    public string Input { get; set; }

    public int Index { get; private set; }

    protected override ComponentConfig<Displayer<InputField>, InputHandler<InputField>> Defaults => new(
        new InputFieldDisplayer(),
        new InputFieldInput()
    );

    public InputField(
        string name,
        string inputText,
        string placeholder = "",
        ComponentConfig<Displayer<InputField>, InputHandler<InputField>>? config = null,
        bool enableOnStart = true)
    : base(name, config, enableOnStart)
    {
        Text = inputText;
        Input = placeholder;
    }

    public void SetIndex(int newIndex) => Index = Math.Clamp(newIndex, 0, Input.Length);
}