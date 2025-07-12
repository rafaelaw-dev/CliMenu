using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.InputFieldBehaviors;
using CliMenu.Helpers;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// Represents a text input field component where the user can type and edit a string.
/// Includes cursor tracking and supports placeholder initialization.
/// </summary>
public sealed class InputField : BaseComponent<Displayer<InputField>, InputHandler<InputField>>
{
    /// <summary>
    /// Label text shown before the input (e.g., "Username:").
    /// </summary>
    public string Text { get; }

    /// <summary>
    /// The current input value typed by the user.
    /// </summary>
    public string Input { get; set; }

    /// <summary>
    /// The cursor index within the input text. Can be used for advanced editing or caret display.
    /// </summary>
    public int Index { get; private set; }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<InputField>, InputHandler<InputField>> Defaults => new(
        new InputFieldDisplayer(),
        new InputFieldInput()
    );

    /// <summary>
    /// Initializes a new instance of the <see cref="InputField"/> component.
    /// </summary>
    /// <param name="name">The internal name of the component.</param>
    /// <param name="inputText">The label to show before the input.</param>
    /// <param name="placeholder">Optional initial text in the input field.</param>
    /// <param name="config">Optional custom configuration for behaviors (display, input, etc.).</param>
    /// <param name="enableOnStart">Determines if the component starts enabled.</param>
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
        Index = Input.Length;
    }

    /// <summary>
    /// Updates the cursor index, clamping it to a valid position within the input.
    /// </summary>
    /// <param name="newIndex">The desired new cursor position.</param>
    public void SetIndex(int newIndex) => Index = Math.Clamp(newIndex, 0, Input.Length);
}