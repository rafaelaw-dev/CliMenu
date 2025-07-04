using CliMenu.Interfaces;

namespace CliMenu.Base;

/// <summary>
/// Abstract base class representing a generic component with executable, display and input handler behaviors.
/// Implements lifecycle management via <see cref="ILifeCycle"/>.
/// </summary>
/// <typeparam name="TExec">Type implementing <see cref="IExecutable"/> for execution behavior.</typeparam>
/// <typeparam name="TDisp">Type implementing <see cref="IDisplayer"/> for display behavior.</typeparam>
/// <typeparam name="TInput">Type implementing <see cref="IInputHandler"/> for input handling behavior.</typeparam>
public abstract class BaseComponent<TExec, TDisp, TInput> : ILifeCycle
    where TExec : IExecutable
    where TDisp : IDisplayer
    where TInput : IInputHandler
{
    /// <summary>
    /// The executable behavior of this component.
    /// </summary>
    protected TExec Executable { get; set; }

    /// <summary>
    /// The display behavior of this component.
    /// </summary>
    protected TDisp Displayer { get; set; }

    /// <summary>
    /// The input handler behavior of this component.
    /// </summary>
    protected TInput InputHandler { get; set; }

    /// <summary>
    /// Provides the default behaviors for executable, display and input handler.
    /// Must be implemented by derived classes.
    /// </summary>
    protected abstract (TExec exec, TDisp disp, TInput input) Defaults { get; }

    /// <summary>
    /// Name identifier for this component.
    /// </summary>
    public string Name { get; }

    /// <inheritdoc/>
    public bool IsActive { get; private set; }

    /// <summary>
    /// Event fired when the component is enabled.
    /// </summary>
    public event Action? OnEnable;

    /// <summary>
    /// Event fired when the component is disabled.
    /// </summary>
    public event Action? OnDisable;

    /// <summary>
    /// Event fired when a key input is received.
    /// </summary>
    public event Action<ConsoleKey>? OnKeyPress;

    /// <summary>
    /// Constructs a component with a name, and initializes default behaviors and enables it.
    /// </summary>
    /// <param name="name">The name of the component.</param>
    public BaseComponent(string name)
    {
        Name = name;

        Executable = Defaults.exec;
        Displayer = Defaults.disp;
        InputHandler = Defaults.input;
        Enable();
    }

    /// <summary>
    /// Sets the executable behavior.
    /// </summary>
    public void SetExecutable(TExec executable) => Executable = executable;

    /// <summary>
    /// Sets the display behavior.
    /// </summary>
    public void SetDisplayer(TDisp displayer) => Displayer = displayer;

    /// <summary>
    /// Sets the input handler behavior.
    /// </summary>
    public void SetInputHandler(TInput inputHandler) => InputHandler = inputHandler;

    /// <summary>
    /// Gets the string to display for this component.
    /// </summary>
    public string GetDisplay() => Displayer.GetDisplay();

    /// <summary>
    /// Executes the component's executable action.
    /// </summary>
    public void Execute() => Executable.Execute();

    /// <summary>
    /// Handles an input key by invoking the input handler and firing OnKeyPress event.
    /// </summary>
    /// <param name="key">The key pressed.</param>
    public void HandleInput(ConsoleKey key)
    {
        OnKeyPress?.Invoke(key);
        InputHandler.HandleInput(key);
    }

    /// <inheritdoc/>
    public virtual void Enable()
    {
        OnEnable?.Invoke();
        IsActive = true;
    }

    /// <inheritdoc/>
    public virtual void Update() { }

    /// <inheritdoc/>
    public virtual void Disable()
    {
        OnDisable?.Invoke();
        IsActive = false;
    }

    /// <summary>
    /// Returns a string representing this component, including its name, active state and focus state if applicable.
    /// </summary>
    public override string ToString() =>
        $"Component '{Name}', Active: {IsActive}, Focused: {(this is IFocusable f ? f.IsFocused.ToString() : "N/A")}";
}