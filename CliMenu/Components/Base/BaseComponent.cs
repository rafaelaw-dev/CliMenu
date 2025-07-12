using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Components.Base;

/// <summary>
/// Represents the abstract base class for all UI components.
/// </summary>
/// <typeparam name="TDisp">The type responsible for display behavior (typically <c>Displayer&lt;Component&gt;</c>).</typeparam>
/// <typeparam name="TInput">The type responsible for input handling behavior (typically <c>InputHandler&lt;Component&gt;</c>).</typeparam>
public abstract class BaseComponent<TDisp, TInput> : IComponent
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    /// <summary>
    /// Gets the display behavior of the component.
    /// </summary>
    public TDisp Displayer { get; private set; }

    /// <summary>
    /// Gets the input handling behavior of the component.
    /// </summary>
    public TInput InputHandler { get; private set; }

    /// <summary>
    /// Gets the focus management behavior of the component.
    /// </summary>
    public IFocusManager FocusManager { get; }

    /// <summary>
    /// Gets the life cycle management behavior of the component.
    /// </summary>
    public ILifeCycle LifeCycle { get; }

    /// <summary>
    /// Gets the name of the component.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the default configuration preset for the component's behaviors.
    /// All components must override this to provide their own defaults.
    /// </summary>
    protected abstract ComponentConfig<TDisp, TInput> Defaults { get; }

    /// <inheritdoc/>
    public bool IsActive => LifeCycle.IsActive;

    /// <inheritdoc/>
    public bool IsFocused => FocusManager.IsFocused;

    /// <summary>
    /// Initializes a new instance of the component.
    /// </summary>
    /// <param name="name">
    /// The name of the component. Must be unique within its menu or group.
    /// </param>
    /// <param name="config">
    /// An optional custom behavior configuration. If <c>null</c>, the <see cref="Defaults"/> will be used.
    /// </param>
    /// <param name="enableOnStart">
    /// Indicates whether the component should be enabled immediately after construction.
    /// </param>
    public BaseComponent(string name, ComponentConfig<TDisp, TInput>? config = null, bool enableOnStart = true)
    {
        Name = name;

        config ??= Defaults;
        Displayer = config.Disp;
        InputHandler = config.Input;
        FocusManager = config.FocusManager;
        LifeCycle = config.LifeCycle;

        if (enableOnStart) LifeCycle.Enable();
    }

    /// <summary>
    /// Returns the rendered display output for this component, using its assigned <see cref="Displayer"/>.
    /// </summary>
    /// <returns>The string representation to be displayed for this component.</returns>
    public string GetDisplay() => Displayer.GetDisplay(this);

    /// <summary>
    /// Handles input for this component using its assigned <see cref="InputHandler"/>.
    /// </summary>
    /// <param name="key">The console key that was pressed.</param>
    public void HandleInput(ConsoleKey key) => InputHandler.HandleInput(this, key);

    /// <summary>
    /// Enables the component using its assigned <see cref="LifeCycle"/>.
    /// </summary>
    public void Enable() => LifeCycle.Enable();

    /// <summary>
    /// Disables the component using its assigned <see cref="LifeCycle"/>.
    /// </summary>
    public void Disable() => LifeCycle.Disable();

    /// <summary>
    /// Sets focus to the component using its assigned <see cref="FocusManager"/>.
    /// </summary>
    public void Focus() => FocusManager.Focus();

    /// <summary>
    /// Removes focus from the component using its assigned <see cref="FocusManager"/>.
    /// </summary>
    public void Blur() => FocusManager.Blur();

    /// <summary>
    /// Returns a string that represents the current state of the component,
    /// including its name, active status, and focus status.
    /// </summary>
    /// <returns>A string describing the component's name, whether it is active, and whether it is focused.</returns>
    public override string ToString() =>
        $"Component '{Name}', Active: {LifeCycle.IsActive}, Focused: {FocusManager.IsFocused}";
}